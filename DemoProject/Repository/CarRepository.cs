namespace DemoProject.Repository
{
    public interface ICarRepository 
    { 
        Car GetCarById(int id);
        List<Car> GetAllCar();
        void AddNewCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(int id);
    }
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _context;
        public CarRepository(AppDbContext context) 
        { 
            _context = context;
        }
        public void AddNewCar(Car car)
        {
            try 
            {
                _context.Cars.Add(car);
                _context.SaveChanges();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public void DeleteCar(int id)
        {
            try 
            { 
                var car = _context.Cars.FirstOrDefault(x => x.Id == id);
                _context.Cars.Remove(car);
                _context.SaveChanges();
            }
            catch(Exception ex) 
            {
                throw ex;
            }

        }

        public List<Car> GetAllCar()
        {
            return _context.Cars.ToList();
        }

        public Car GetCarById(int id)
        {
            var car = GetAllCar().Where(x=>x.Id == id).FirstOrDefault();
            return car;
        }

        public void UpdateCar(Car car)
        {
            try 
            {
                _context.Cars.Update(car);
                _context.SaveChanges();
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }
    }
}
