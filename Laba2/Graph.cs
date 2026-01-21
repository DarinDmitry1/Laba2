using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Route
    {
        public City Destination { get; set; }
        public double Cost { get; set; }

        public Route(City destination, double cost)
        {
            Destination = destination;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"{Destination.Name}:{Cost}";
        }
    }

    public class City
    {
        public string Name { get; set; }
        public List<Route> Routes { get; set; } = new List<Route>();

        public City(string name)
        {
            Name = name;
        }

        public void AddRoute(City destination, double cost)
        {
            Routes.Add(new Route(destination, cost));
        }

        public override string ToString()
        {
            if (Routes.Count == 0)
                return $"{Name} (нет маршрутов)";

            string routesStr = string.Join(", ", Routes.Select(r => r.ToString()));
            return $"{Name} -> {routesStr}";
        }
    }
}
