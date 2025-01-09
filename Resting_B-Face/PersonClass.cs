using System.Text.Json.Serialization;

public class Person{
    public string name { get; set; }
    public int height { get; set; }
    public int mass { get; set; }
    public string hair_color { get; set; }
    public string skin_color { get; set; }
    public string eye_color { get; set; }
    public string birth_year { get; set; }
    public string gender { get; set; }
    public string homeworld { get; set; }
    public List<string> films { get; set; }
    public List<string> species { get; set; }
    public List<string> vehicles { get; set; }
    public List<string> starships { get; set; }

    public void Show(){
        Console.Clear();
        Console.WriteLine(name);
        Console.WriteLine("Height: "+height);
        Console.WriteLine("Weight: "+mass);
        Console.WriteLine("Hair Color: "+hair_color);
        Console.WriteLine("Skin Color: "+skin_color);
        Console.WriteLine("Eye Color: "+eye_color);
        Console.WriteLine("Birth Year: "+birth_year);
        Console.WriteLine("Gender: "+gender);
        Console.WriteLine("Homeworld: "+homeworld);
        Console.WriteLine("Films:");
        for (int i = 0; i < films.Count; i++)   Console.WriteLine("     "+films[i]);
        Console.WriteLine("Species:");
        for (int i = 0; i < species.Count; i++)   Console.WriteLine("     "+species[i]);
        Console.WriteLine("Vehicles:");
        for (int i = 0; i < vehicles.Count; i++)   Console.WriteLine("     "+vehicles[i]);
        Console.WriteLine("Starships:");
        for (int i = 0; i < starships.Count; i++)   Console.WriteLine("     "+starships[i]);
        Console.ReadLine();
    }
}

public class Planet{
    public string name { get; set; }
    public int rotation_period { get; set; }
    public int orbital_period { get; set; }
    public int diameter { get; set; }
    public string climate { get; set; }
    public string gravity { get; set; }
    public string terrain { get; set; }
    public int surface_water { get; set; }
    public int population { get; set; }
    public List<string> residents { get; set; }
    public List<string> films { get; set; }

    public void Show(){
        Console.Clear();
        Console.WriteLine(name);
        Console.WriteLine("Rotation Period: "+rotation_period);
        Console.WriteLine("Orbital Period: "+orbital_period);
        Console.WriteLine("Diameter: "+diameter);
        Console.WriteLine("Climate: "+climate);
        Console.WriteLine("Gravity: "+gravity);
        Console.WriteLine("Terrain: "+terrain);
        Console.WriteLine("Surface Water: "+surface_water);
        Console.WriteLine("Population: "+population);
        Console.WriteLine("Residents:");
        for (int i = 0; i < residents.Count; i++)   Console.WriteLine("     "+residents[i]);
        Console.WriteLine("Films:");
        for (int i = 0; i < films.Count; i++)   Console.WriteLine("     "+films[i]);
        Console.ReadLine();
    }
}

public class Starship{
    public string name { get; set; }
    public string model { get; set; }
    public string manufacturer { get; set; }
    public int cost_in_credits { get; set; }
    public int length { get; set; }
    public int max_atmosphering_speed { get; set; }
    public string crew { get; set; }
    public int passengers { get; set; }
    public int cargo_capacity { get; set; }
    public string consumables { get; set; }
    public double hyperdrive_rating { get; set; }
    public int MGLT { get; set; }
    public string starship_class { get; set; }
    public List<string> pilots { get; set; }
    public List<string> films { get; set; }

    public void Show(){
        Console.Clear();
        Console.WriteLine(name);
        Console.WriteLine("Manufacturer: "+manufacturer);
        Console.WriteLine("Cost: "+cost_in_credits);
        Console.WriteLine("Length: "+length);
        Console.WriteLine("Max Atmospher Speed: "+max_atmosphering_speed);
        Console.WriteLine("Crew Size: "+crew);
        Console.WriteLine("Max Passengers: "+passengers);
        Console.WriteLine("Cargo Capacity: "+cargo_capacity);
        Console.WriteLine("Consumables: "+consumables);
        Console.WriteLine("Hyperdrive Rating: "+hyperdrive_rating);
        Console.WriteLine("MGLT: "+MGLT);
        Console.WriteLine("Starship Class: "+starship_class);
        Console.WriteLine("Pilots:");
        for (int i = 0; i < pilots.Count; i++)   Console.WriteLine("     "+pilots[i]);
        Console.WriteLine("Films:");
        for (int i = 0; i < films.Count; i++)   Console.WriteLine("     "+films[i]);
        Console.ReadLine();
    }
}