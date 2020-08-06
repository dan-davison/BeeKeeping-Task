using System.Collections.Generic;
using System;

namespace BeeKeeping_DanDavison
{
    public class Beehive
    {
        public List<Bee> Beelist = new List<Bee>();
        public int MaxAmountOfBees;

        public Beehive(int MaxBees){
            MaxAmountOfBees = MaxBees;
        }

        //Add Bee
        public void AddBee(Bee bee){
            if(Beelist.Count > MaxAmountOfBees) {
            return;    
            }
            else {
            Beelist.Add(bee);
            }  
        }
        //Collect Honey
        public void CollectHoney(int days){  
            float amount = 0;
           
            foreach (var Bee in Beelist){

                float count = 0;
                count += days * Bee.BeeSize * 0.2f;  
                amount += count;
            }

          Console.WriteLine("Honey ammount collected: " + amount);
        }
    }

}