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
            _paymentRepository.Add(entity);
        }

        public void Delete(Payment entity)
        {
            _paymentRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _paymentRepository.Delete(Get(id));
        }

        public void Update(Payment entity)
        {
            _paymentRepository.Update(entity);
        }

        public Payment Get(int entityID)
        {
            return _paymentRepository.Get(x => x.PaymentID == entityID);
        }

        public ICollection<Payment> GetAll()
        {
            return _paymentRepository.GetAll();
        }
    }
}
