using DemoProject.Repository;

namespace DemoProject.Service
{
    public interface ICarService 
    { 
        List<Car> GetAllCars();
        Car GetCarById(int carId);
        List<Car> SearchCar(string searchkey);
        void AddNewCar(Car car);
        void DeleteCar(int carId);
        void UpdateCar(Car car);

    }
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository) 
        { 
            _carRepository = carRepository;
        }
        public void AddNewCar(Car car)
        {
            _carRepository.AddNewCar(car);
        }

        public void DeleteCar(int carId)
        {
            _carRepository.DeleteCar(carId); 
        }

        public List<Car> GetAllCars()
        {
            return _carRepository.GetAllCar();
        }

        public Car GetCarById(int carId)
        {
           return _carRepository.GetCarById(carId);
        }

        public List<Car> SearchCar(string searchkey)
        {
            return _carRepository.GetAllCar().Where(x=>x.Name.Contains(searchkey)).ToList();
        }

        public void UpdateCar(Car car)
        {
           _carRepository.UpdateCar(car);
        }
    }
}
