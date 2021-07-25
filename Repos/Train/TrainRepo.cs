using Entities.Models.Entities;
using IRepos.Train;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Train
{
    public class TrainRepo : ITrainRepo
    {
        public bool CreateTrain(TblTrain train)
        {
            bool result = false;
            using (var context = new RouteManagementContext())
            {
                try
                {
                    context.TblTrains.Add(train);
                    result = context.SaveChanges() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return result;
        }

        public bool DeleteTrain(string id)
        {
            bool result = false;
            using (var context = new RouteManagementContext())
            {
                try
                {
                    var train = ReadTrainById(id);
                    context.TblTrains.Remove(train);
                    result = context.SaveChanges() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return result;
        }

        public List<TblTrain> ReadAllTrains()
        {
            var list = new List<TblTrain>();
            using (var context = new RouteManagementContext())
            {
                try
                {
                    list = context.TblTrains.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return list;
        }

        public TblTrain ReadTrainById(string id)
        {
            var data = new TblTrain();
            using (var context = new RouteManagementContext())
            {
                try
                {
                    data = context.TblTrains.Where((TblTrain train) => train.Id == id) as TblTrain;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return data;
        }

        public bool UpdTrain(TblTrain train)
        {
            bool result = false;
            using (var context = new RouteManagementContext())
            {
                try
                {
                    context.TblTrains.Update(train);
                    result = context.SaveChanges() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return result;
        }
    }
}
