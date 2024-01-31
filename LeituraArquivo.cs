﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LeituraArquivo
    {
        public (bool sucesso,string[] Linhas,int QntLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);

                return (true, linhas, linhas.Count());
            }catch (Exception)
            {
                return (false, new string[0], 0);
            }
            
            
        }
    }
}
