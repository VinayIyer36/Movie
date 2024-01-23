using System;
using System.Collections.Generic;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Movie;
using Movie.Models.DB;
using Movie.Repository;

namespace MovieWorker
{
    public class Function1
    {
        [FunctionName("Function1")]
        public void Run([TimerTrigger("0 */5 * * * *")] TimerInfo myTimer, ILogger log)
        {
            GenerateReport();
        }

        public void GenerateReport()
        {
            using (UnitOfWork UoW = new UnitOfWork())
            {
                IEnumerable<Actor> actors = UoW.ActorRepo.GetAll();

                int genreCount = UoW.GenreRepo.GetGenresCount();
            }

        }
    }
}
