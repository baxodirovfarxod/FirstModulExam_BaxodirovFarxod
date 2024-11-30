using Exam.Models;

namespace Exam.Services
{
    public class HouseServices
    {
        private List<House> houses;

        public HouseServices()
        {
            houses = new List<House>();
        }

        public House Add(House house)
        {
            house.id = Guid.NewGuid();
            houses.Add(house);

            return house;
        }

        public House GetById(Guid id)
        {
            foreach (var house in houses)
            {
                if (house.id = id)
                {
                    return house;
                }
            }

            return null;
        }

        public bool Delete(Guid id)
        {
            var houseFromDB = GetById(id);
            if (houseFromDB is null)
            {
                return false;
            }
            houses.Remove(houseFromDB);

            return true;
        }

        public bool Update(House house)
        {
            var houseFromDB = GetById(house.id);
            if (houseFromDB is null)
            {
                return false;
            }
            var index = houses.IndexOf(houseFromDB);
            houses[index] = house;

            return true;
        }

        public List<House> GetAll()
        {
            return houses;
        }
    }
}
