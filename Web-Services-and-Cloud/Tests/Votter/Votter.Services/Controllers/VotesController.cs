namespace Votter.Services.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Http;
    using Votter.Models;
    using Votter.Data;
using Votter.Services.Models;

    //[Authorize]
    public class VotesController : ApiController
    {
        private VotterData data;

        public VotesController()
        {
            data = new VotterData();
        }

        [HttpPost]
        public IHttpActionResult Create([FromBody]VoteModel vote)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Created vote is not valid!");
            }

            // Check if pictures exists
            var upVotePicture = this.data.Pictures.Find(vote.UpVotePictureId);
            var downVotePicture = this.data.Pictures.Find(vote.DownVotePictureId);
            if (upVotePicture == null || downVotePicture == null)
            {
                return BadRequest("Cannot find pictures in database!");
            }

            // Check if ids are equal
            if (vote.UpVotePictureId == vote.DownVotePictureId)
            {
                return BadRequest("Cannot compare pictures that are the same!");
            }

            // Check if ids belongs to a same person
            if (upVotePicture.ApplicationUserId == downVotePicture.ApplicationUserId)
            {
                return BadRequest("Cannot compare pictures that belongs to a same person!");
            }

            // Check if pictures are from different categories
            if (upVotePicture.CategoryId != downVotePicture.CategoryId)
            {
                return BadRequest("Cannot compare pictures from different categories!");
            }

            var newVote = new Vote
            {
                ApplicationUserId = vote.UserId,
                DownVotePicture = downVotePicture,
                UpVotePicture = upVotePicture,
            };
            this.data.Votes.Add(newVote);

            downVotePicture.Score.Points++;
            upVotePicture.Score.Points--;

            this.data.SaveChanges();

            return Ok(newVote.VoteId);
        }
    }
}