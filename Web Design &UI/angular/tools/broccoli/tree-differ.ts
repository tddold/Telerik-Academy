/// <reference path="../typings/node/node.d.ts" />

import fs = require('fs');
import path = require('path');


export = TreeDiffer;

class TreeDiffer {
  private fingerprints: {[key: string]: string} = Object.create(null);
  private nextFingerprints: {[key: string]: string} = Object.create(null);
  private rootDirName: string;

  constructor(private rootPath: string) { this.rootDirName = path.basename(rootPath); }


  public diffTree(): DiffResult {
    let result = new DiffResult(this.rootDirName);
    this.dirtyCheckPath(this.rootPath, result);
    this.detectDeletionsAndUpdateFingerprints(result);
    result.endTime = Date.now();
    return result;
  }


  private dirtyCheckPath(rootDir: string, result: DiffResult) {
    fs.readdirSync(rootDir).forEach((segment) => {
      let absolutePath = path.join(rootDir, segment);
      let pathStat = fs.statSync(absolutePath);

      if (pathStat.isDirectory()) {
        result.directoriesChecked++;
        this.dirtyCheckPath(absolutePath, result);
      } else {
        result.filesChecked++;
        if (this.isFileDirty(absolutePath, pathStat)) {
          result.changedPaths.push(path.relative(this.rootPath, absolutePath));
        }
      }
    });

    return result;
  }


  private isFileDirty(path: string, stat: fs.Stats): boolean {
    let oldFingerprint = this.fingerprints[path];
    let newFingerprint = `${stat.mtime.getTime()} # ${stat.size}`;

    this.nextFingerprints[path] = newFingerprint;

    if (oldFingerprint) {
      this.fingerprints[path] = null;

      if (oldFingerprint === newFingerprint) {
        // nothing changed
        return false;
      }
    }

    return true;
  }


  private detectDeletionsAndUpdateFingerprints(result: DiffResult) {
    for (let absolutePath in this.fingerprints) {
      if (this.fingerprints[absolutePath] !== null) {
        let relativePath = path.relative(this.rootPath, absolutePath);
        result.removedPaths.push(relativePath);
      }
    }

    this.fingerprints = this.nextFingerprints;
    this.nextFingerprints = Object.create(null);
  }
}


class DiffResult {
  public filesChecked: number = 0;
  public directoriesChecked: number = 0;
  public changedPaths: string[] = [];
  public removedPaths: string[] = [];
  public startTime: number = Date.now();
  public endTime: number = null;

  constructor(public name: string) {}

  toString() {
    return `${pad(this.name, 40)}, ` +
           `duration: ${pad(this.endTime - this.startTime, 5)}ms, ` +
           `${pad(this.changedPaths.length + this.removedPaths.length, 5)} changes detected ` +
           `(files: ${pad(this.filesChecked, 5)}, directories: ${pad(this.directoriesChecked, 4)})`;
  }

  log(verbose) {
    let prefixedPaths =
        this.changedPaths.map((p) => `* ${p}`).concat(this.removedPaths.map((p) => `- ${p}`));
    console.log(`Tree diff: ${this}` +
                ((verbose && prefixedPaths.length) ? ` [\n  ${prefixedPaths.join('\n  ')}\n]` :  ''));
  }
}


function pad(value, length) {
  value = '' + value;
  let whitespaceLength = (value.length < length) ? length - value.length : 0;
  whitespaceLength = whitespaceLength + 1;
  return new Array(whitespaceLength).join(' ') + value;
}
