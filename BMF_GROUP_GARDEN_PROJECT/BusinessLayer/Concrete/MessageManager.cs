using BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_;
using EntityLayer;
using System.Linq.Expressions;
using DataAccessLayer_.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
   public  class MessageManager :GenericManager<MessageManager> 
    {

        private readonly IRepository<MessageManager> _repository;


        public MessageManager(IRepository<MessageManager> repository) : base(repository) 
        {
            _repository = repository;
        }


    }
}
