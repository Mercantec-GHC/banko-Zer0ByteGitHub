using System;
using System.Collections.Generic;
using System.Linq;



public class BankoPlade
{
    public Guid PladeID { get; set; }
    public List<List<int>> Rækker { get; set; }
    public bool FuldPlade { get; set; }
}



public class Program
{
    public static void Main()
    {
        // Opret en BankoPlade
        var bankoPlade = new BankoPlade
        {
            PladeID = Guid.NewGuid(),
            Rækker = new List<List<int>>()
        };



        // Tilføj BankoPlade til dictionary
        Dictionary<Guid, BankoPlade> bankoPlader = new Dictionary<Guid, BankoPlade>();
        bankoPlader.Add(bankoPlade.PladeID, bankoPlade);



        // Erklær pladeID og rækkeNummer
        Guid pladeID = bankoPlade.PladeID;
        int rækkeNummer = 0;
        int tal = 42;



        // Tjek om pladen er fuld
        if (bankoPlader.ContainsKey(pladeID))
        {
            var plade = bankoPlader[pladeID];
            if (rækkeNummer < plade.Rækker.Count)
            {
                plade.Rækker[rækkeNummer].Remove(tal);



                if (plade.Rækker.All(række => række.Count == 0))
                {
                    plade.FuldPlade = true;
                }
            }
        }
    }
}