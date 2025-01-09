using System.Net.Http.Json;
using RestSharp;

int index=1;
string type="people";
Planet planet=new();
Person person=new();
Starship starship=new();

bool check=true;
bool check2=true;
string resp;
HttpClient client=new();
client.BaseAddress=new("https://swapi.py4e.com/api/");

while(check){
    Console.Clear();
    Console.WriteLine("Search within the Star Wars API\na) People\nb) Spaceships\nc) Planets");
    resp=Console.ReadLine().ToLower();
    switch(resp){
        case "a":
            type="people";
            check=false;
        break;

        case "b":
            type="starships";
            check=false;
        break;

        case "c":
            type="planets";
            check=false;
        break;
    }
}

check2=false;
while(check2==false){
    Console.Clear();
    Console.WriteLine("What index?");
    resp=Console.ReadLine().ToLower();
    check2=int.TryParse(resp, out index);
}


HttpResponseMessage response=client.GetAsync(type+"/"+index+"/").Result;

switch(type){
    case "people":
        person=response.Content.ReadFromJsonAsync<Person>().Result;
        person.Show();
    break;
    case "starships":
        starship=response.Content.ReadFromJsonAsync<Starship>().Result;
        starship.Show();
    break;
    case "planets":
        planet=response.Content.ReadFromJsonAsync<Planet>().Result;
        planet.Show();
    break;
}
Console.Clear();
Console.WriteLine("Save Data?\ny/n");
resp=Console.ReadLine().ToLower();

if(resp=="y"){
    switch(type){
        case "people":
            File.WriteAllText(person.name+".json",response.Content.ReadAsStringAsync().Result);
        break;
        case "starships":
            File.WriteAllText(starship.name+".json",response.Content.ReadAsStringAsync().Result);
        break;
        case "planets":
            File.WriteAllText(planet.name+".json",response.Content.ReadAsStringAsync().Result);
        break;
    }
}