using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApp.Core.Abstract;

namespace WebApp.NLog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        #region ctor

        readonly ILoggingService logger;

        public HomeController(ILoggingService logger)
        {
            this.logger = logger;
        }

        #endregion

        [HttpGet]
        public IEnumerable<string[]> Get()
        {
            logger.LogInfo(SetMethodNameForLogMessage(nameof(Get)), "metodu çağrıldı.");

            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                logger.LogError(SetMethodNameForLogMessage(nameof(Get)), "Uygulama da bir hata oluştu.", ex);
                return null;
            }
        }

        string SetMethodNameForLogMessage(string methodName)
        {
            return $"{GetType().Name}.{methodName}";
        }
    }
}