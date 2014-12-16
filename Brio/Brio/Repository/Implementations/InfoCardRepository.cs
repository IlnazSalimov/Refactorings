﻿using Brio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brio
{
    public class InfoCardRepository : IInfoCardRepository
    {
         private IRepository<InfoCard> infoCardRepository;

        public InfoCardRepository(IRepository<InfoCard> infoCardRepository)
        {
            this.infoCardRepository = infoCardRepository;
        }
        public IQueryable<InfoCard> GetAll()
        {
            return infoCardRepository.GetAll();
        }

        public InfoCard GetById(int id)
        {
            if (id == 0)
                return null;
            return infoCardRepository.GetById(id);
        }

        public InfoCard GetUserInfoCard(int userId)
        {
            if (userId == 0)
                return null;
            return infoCardRepository.GetAll().Where(i => i.UserId == userId).FirstOrDefault();
        }

        public void Insert(InfoCard model)
        {
            if (model == null)
                throw new ArgumentNullException("InfoCard");
            infoCardRepository.Insert(model);
        }

        public void Update(InfoCard model)
        {
            if (model == null)
                throw new ArgumentNullException("InfoCard");
            infoCardRepository.Update(model);

        }

        public void Delete(InfoCard model)
        {
            if (model == null)
                throw new ArgumentNullException("InfoCard");
            infoCardRepository.Delete(model);
        }

        public void SaveChanges()
        {
            infoCardRepository.SaveChanges();
        }
    }
}
