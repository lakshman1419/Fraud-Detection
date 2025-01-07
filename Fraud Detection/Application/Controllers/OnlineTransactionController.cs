using Fraud_Detection.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fraud_Detection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OnlineTransactionController : ControllerBase
    {

        [HttpGet(Name = "GetAllTransaction")]
        public List<OnlineTransaction> Get()
        {
            List<OnlineTransaction> onlineTransactions = new List<OnlineTransaction>();
            onlineTransactions.Add(new OnlineTransaction("Abc","Processing","Card Payment",5000, Convert.ToDateTime("06/01/2025"),"Shiva"));
            return onlineTransactions;
        }
    }
}
