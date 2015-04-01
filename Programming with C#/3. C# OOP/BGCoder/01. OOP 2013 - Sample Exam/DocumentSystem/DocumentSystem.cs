using DocumentSystem.Models;

namespace DocumentSystem
{
   
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DocumentSystem
    {
        private static ICollection<IDocument> documents = new List<IDocument>();

        public static void Main()
        {
            IList<string> allCommands = ReadAllCommands();
            ExecuteCommands(allCommands);
        }

        private static IList<string> ReadAllCommands()
        {
            List<string> commands = new List<string>();
            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == "")
                {
                    // End of commands
                    break;
                }
                commands.Add(commandLine);
            }
            return commands;
        }

        private static void ExecuteCommands(IList<string> commands)
        {
            foreach (var commandLine in commands)
            {
                int paramsStartIndex = commandLine.IndexOf("[");
                string cmd = commandLine.Substring(0, paramsStartIndex);
                int paramsEndIndex = commandLine.IndexOf("]");
                string parameters = commandLine.Substring(
                    paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
                ExecuteCommand(cmd, parameters);
            }
        }

        private static void ExecuteCommand(string cmd, string parameters)
        {
            string[] cmdAttributes = parameters.Split(
                new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (cmd == "AddTextDocument")
            {
                AddTextDocument(cmdAttributes);
            }
            else if (cmd == "AddPDFDocument")
            {
                AddPdfDocument(cmdAttributes);
            }
            else if (cmd == "AddWordDocument")
            {
                AddWordDocument(cmdAttributes);
            }
            else if (cmd == "AddExcelDocument")
            {
                AddExcelDocument(cmdAttributes);
            }
            else if (cmd == "AddAudioDocument")
            {
                AddAudioDocument(cmdAttributes);
            }
            else if (cmd == "AddVideoDocument")
            {
                AddVideoDocument(cmdAttributes);
            }
            else if (cmd == "ListDocuments")
            {
                ListDocuments();
            }
            else if (cmd == "EncryptDocument")
            {
                EncryptDocument(parameters);
            }
            else if (cmd == "DecryptDocument")
            {
                DecryptDocument(parameters);
            }
            else if (cmd == "EncryptAllDocuments")
            {
                EncryptAllDocuments();
            }
            else if (cmd == "ChangeContent")
            {
                ChangeContent(cmdAttributes[0], cmdAttributes[1]);
            }
            else
            {
                throw new InvalidOperationException("Invalid command: " + cmd);
            }
        }

        private static void AddTextDocument(string[] attributes)
        {
            IDocument doc = new TextDocument("");
            AddDocument(attributes, doc);
        }        

        private static void AddPdfDocument(string[] attributes)
        {
            IDocument doc = new PDFDocument("");
            AddDocument(attributes, doc);
        }

        private static void AddWordDocument(string[] attributes)
        {
            IDocument doc = new WordDocument("");
            AddDocument(attributes, doc);
        }

        private static void AddExcelDocument(string[] attributes)
        {
            IDocument doc = new ExcelDocument("");
            AddDocument(attributes, doc);
        }

        private static void AddAudioDocument(string[] attributes)
        {
            IDocument doc = new AudioDocument("");
            AddDocument(attributes, doc);
        }

        private static void AddVideoDocument(string[] attributes)
        {
            IDocument doc = new VideoDocument("");
            AddDocument(attributes, doc);
        }

        private static void ListDocuments()
        {
            if (documents.Any())
            {
                foreach (var doc in documents)
                {
                    Console.WriteLine(doc);
                }    
            }
            else
            {
                Console.WriteLine("No documents found");
            }
            
        }

        private static void EncryptDocument(string name)
        {
            var encryptableDocs = documents
                .Where(d => d.Name == name);

            if (encryptableDocs.Any())
            {
                foreach (IDocument doc in encryptableDocs)
                {
                    var encryptableDoc = doc as IEncryptable;

                    if (encryptableDoc != null)
                    {
                        encryptableDoc.Encrypt();
                        Console.WriteLine("Document encrypted: {0}", doc.Name);
                    }
                    else
                    {
                        Console.WriteLine("Document does not support encryption: {0}", doc.Name);
                    }
                }    
            }
            else
            {
                Console.WriteLine("Document not found: {0}", name);
            }
            
        }

        private static void DecryptDocument(string name)
        {
            var encryptableDocs = documents
                 .Where(d => d.Name == name);

            if (encryptableDocs.Any())
            {
                foreach (IDocument doc in encryptableDocs)
                {
                    var encryptableDoc = doc as IEncryptable;

                    if (encryptableDoc != null)
                    {
                        encryptableDoc.Decrypt();
                        Console.WriteLine("Document decrypted: {0}", doc.Name);
                    }
                    else
                    {
                        Console.WriteLine("Document does not support decryption: {0}", doc.Name);
                    }
                }
            }
            else
            {
                Console.WriteLine("Document not found: {0}", name);
            }
        }

        private static void EncryptAllDocuments()
        {
            var encryptableDocs = documents
                .Where(d => d is IEncryptable)
                .Select(d => d as IEncryptable);

            if (encryptableDocs.Any())
            {
                foreach (IEncryptable doc in encryptableDocs)
                {
                    doc.Encrypt();
                }

                Console.WriteLine("All documents encrypted");
            }
            else
            {
                Console.WriteLine("No encryptable documents found");
            }

            
        }

        private static void ChangeContent(string name, string content)
        {
            var editableDocs = documents.Where(d => d.Name == name);

            if (editableDocs.Any())
            {
                foreach (var doc in editableDocs)
                {
                    var editableDoc = doc as IEditable;

                    if (editableDoc != null)
                    {
                        editableDoc.ChangeContent(content);
                        Console.WriteLine("Document content changed: {0}", name);
                    }
                    else
                    {
                        Console.WriteLine("Document is not editable: {0}", name);
                    }
                } 
                
            }
            else
            {
                Console.WriteLine("Document not found: {0}", name);
            }
        }

        private static void AddDocument(string[] attributes, IDocument doc)
        {
            foreach (string attr in attributes)
            {
                string[] key = attr.Split('=');
                doc.LoadProperty(key[0], key[1]);
            }

            if (!string.IsNullOrEmpty(doc.Name))
            {
                documents.Add(doc);
                Console.WriteLine("Document added: {0}", doc.Name);
            }
            else
            {
                Console.WriteLine("Document has no name");
            }
        }
    }
}
