using System;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    public class DeliveriesController: ControllerBase
    {

        private readonly ILogger<DeliveriesController> _logger;
        private readonly IDeliveryService _deliveryService;



        public DeliveriesController(ILogger<DeliveriesController> logger,IDeliveryService deliveryService)
        {
            _logger = logger;
            _deliveryService = deliveryService;
        }

















    }
}
