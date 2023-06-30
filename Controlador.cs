using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManejoJson.Entities;
using Newtonsoft.Json;


namespace ManejoJson;

internal class Program
{
    public class Controlador
    {
        List<Team> teams = new List<Team>();
        public Controlador (){
            if (!ExistsFile()){
                CrearFile();
            } 
        }
        public bool ExistsFile(){
            bool isValid = true;
            if (File.Exists("fifawc.json")){
                isValid = true;
            }else{
                isValid = false;
            }
            return isValid;
        }
    
        public void CrearFile(){
            if(!ExistsFile()){
                File.Create("fifawc.json");
            }
        }
        public void AddInfo(){
            Team equipo = new Team();
            Console.WriteLine("Ingrese el Id del equipo");
            equipo.IdTeam = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del equipo");
            equipo.NameTeam = Console.ReadLine();
            teams.Add(equipo);
            saveDataFile();
        }
        public void AddPlayerToTeam(string Id){
            bool isAddPlayer = true;
            do{
                Player players = new Player();
                Console.WriteLine("Ingrese el número del Dorsal");

            }
        }
        public void saveDataFile(){
            string json = JsonConvert.SerializeObject(teams, Formatting.Indented);
            File.WriteAllText("fifawc.json", json);
        }
        public void EditDataFile(){
            Team teamToEdit = new Team();
        }

    }
}

