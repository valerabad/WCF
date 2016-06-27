using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class DataTransferService : IContract
    {
        public List<Player> listPlayers = new List<Player>();
        public DataTransferService()
        {
            listPlayers.Add(new Player(1,"Саша","Иванов",33));
            listPlayers.Add(new Player(2, "Петя", "Сидоров", 44));
        }

        public int CalcFactorial(int i)
        {
            int result;        
            if (i == 1)
                return 1;
            result = CalcFactorial(i - 1) * i;
            return result;            
        }

        public string ReversString(string param)
        {                           
            return new string(param.ToCharArray().Reverse().ToArray()); 
        }

        public bool ReturnBool(bool param)
        {
            return param;
        }
        
        public Player GetPlayer(int id)
        {
            return listPlayers.Find(x => x.ID == id);

        }
                
        public void SetPlayer(Player player)
        {
            listPlayers.Add(player);                   
        }
    }
}
