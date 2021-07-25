using Entities.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepos.Train
{
    public interface ITrainRepo
    {
        bool CreateTrain(TblTrain train);

        TblTrain ReadTrainById(string id);

        List<TblTrain> ReadAllTrains();

        bool UpdTrain(TblTrain train);

        bool DeleteTrain(string id);
    }
}
