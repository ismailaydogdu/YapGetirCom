using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.BLL.Abstract;
using YapGetirCom.DAL.Repositories.Abstract;
using YapGetirCom.Model;

namespace YapGetirCom.BLL.Concrete
{
    public class PaymentService : IPaymentService
    {
        public IPaymentRepository _paymentRepository;
        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }
        public void Insert(Payment entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Payment entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Payment entity)
        {
            throw new NotImplementedException();
        }

        public Payment Get(int entityID)
        {
            throw new NotImplementedException();
        }

        public ICollection<Payment> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
