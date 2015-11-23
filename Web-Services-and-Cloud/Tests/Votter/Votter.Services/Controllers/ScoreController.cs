using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Votter.Data;
using Votter.Models;
using Votter.Data.Repositories;
using Votter.Data.Contracts;
using Votter.Services.Models;

namespace Votter.Services.Controllers
{
    public class ScoreController : ApiController
    {
        private static readonly Random random = new Random();
        private readonly VotterData data;

        public ScoreController()
        {
            data = new VotterData();
        }

        [HttpGet]
        public IQueryable<ScoreModel> GetRank(int topScoresUpperLimit)
        {
            return this.data.Scores
                .All()
                .OrderByDescending(r => r.Points)
                .Take(topScoresUpperLimit)
                .Select(p=> new ScoreModel()
                {
                    PictureId = p.Id,
                    Score = p.Points
                });
        }

        [HttpGet]
        public ScoreModel GetRankByPictureId(int pictureId)
        {
            return this.data.Scores
                .All()
                .Where(x => x.Id == pictureId)
                .Select(p=> new ScoreModel()
                {
                    PictureId = p.Id,
                    Score = p.Points
                }).FirstOrDefault();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.data.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}