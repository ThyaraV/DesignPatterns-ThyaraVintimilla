using DesignPatterns.Models;
using DesignPatterns.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.ModelBuilders;
using DesignPatterns.Factories;

namespace DesignPatterns.Controllers
{
    public class Director<T>
    {
        // Propiedad que almacena una referencia a cualquier objeto que implemente 'IBuilder<T>'.
        public IBuilder<T> Builder { get; set; }
        // Constructor que inicializa 'Director' con una instancia específica de 'IBuilder<T>'.
        public Director(IBuilder<T> builder)
        {
            Builder = builder;
        }
        // Método que delega la construcción del objeto a la instancia de 'IBuilder<T>'.
        public T Build()
        {
            return Builder.Build();
        }
    }
    public class HomeController : Controller
    {
        // Campos para el repositorio de vehículos y el logger.
        private readonly ILogger<HomeController> _logger;

        private readonly IVehicleRepository _vehicleRepository;

        // Constructor que inyecta las dependencias.
        public HomeController(IVehicleRepository vehicleRepository,ILogger<HomeController> logger)
        {
            _vehicleRepository = vehicleRepository;
            _logger = logger;
        }

        // Método de acción para manejar la ruta por defecto '/'.
        public IActionResult Index()
        {
            // Creación y configuración del modelo de vista.
            var model = new HomeViewModel();
            model.Vehicles = _vehicleRepository.GetVehicles();
            // Manejo de errores a través de la QueryString.
            string error = Request.Query.ContainsKey("error") ? Request.Query["error"].ToString() : null;
            ViewBag.ErrorMessage = error;

            // Retorna la vista con el modelo.
            return View(model);
        }

        // Método privado para crear y añadir un vehículo al repositorio.
        private void CreateVehicle(Creator creator)
        {
            _vehicleRepository.AddVehicle(creator.Create());
        }

         // Métodos de acción para añadir diferentes tipos de vehículos.
         // Utilizan el patrón Factory Method para la creación de vehículos.
        [HttpGet]
        public IActionResult AddMustang()
        {
            /*
            var builder=new CarBuilder();
            _vehicleRepository.AddVehicle(builder.Build());
            return Redirect("/");*/

            var creator = new FordMustangCreator();
            CreateVehicle(creator);
            return Redirect("/");
        }

        public IActionResult AddMoto()
        {
            
            var builder = new MotocycleBuilder();
            _vehicleRepository.AddVehicle(builder.Build());
            return Redirect("/");
        }

        [HttpGet]
        public IActionResult AddExplorer()
        {
            var creator = new FordExplorerCreator();
            CreateVehicle(creator);
            return Redirect("/");
        }

        public IActionResult AddEscape()
        {
            var creator = new FordEscapeCreator();
            CreateVehicle(creator);
            return Redirect("/");
        }

         // Métodos de acción para interactuar con los vehículos (iniciar motor, añadir gas, detener motor).
         // Manejo de excepciones para errores durante la operación.
        [HttpGet]
        public IActionResult StartEngine(string id)
        {
            try
            {
                var vehicle = _vehicleRepository.Find(id);
                vehicle.StartEngine();
                return Redirect("/");
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return Redirect($"/?error={ex.Message}");
            }
          
        }

        [HttpGet]
        public IActionResult AddGas(string id)
        {

            try
            {
                var vehicle = _vehicleRepository.Find(id);
                vehicle.AddGas();
                return Redirect("/");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return Redirect($"/?error={ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult StopEngine(string id)
        {
            try
            {
                var vehicle = _vehicleRepository.Find(id);
                vehicle.StopEngine();
                return Redirect("/");
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return Redirect($"/?error={ex.Message}");
            }
           
           
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
