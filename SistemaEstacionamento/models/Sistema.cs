using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaEstacionamento.models.Sistema
{
    public class Sistema
    {
        public void Executar(){
            
            bool fechar = true;
            List<string> veiculo = new List<string>();
            

            while(fechar){
            Console.WriteLine("Opção 1 - Adicionar veiculo\nOpção 2 - Remover veiculo\nOpção 3 - Listar veiculo\nOpção 4 - Para fechar o programa");
            int opcao = Convert.ToInt32(Console.ReadLine());
                
                switch(opcao){
                
                case 1:
                Console.WriteLine("Liste a placa veiculo por favor");
                
                break;
                case 2:
                Console.WriteLine($"digite a placa do carros listado aqui a baixo:");
                foreach(string contagem in veiculo){
                          
                          Console.WriteLine($"{contagem}");
                    }
                    Console.WriteLine($"___________________________________");
                
                break;
                case 3:
                break;
                case 4:
                break;
                default:
                Console.WriteLine("opção invalida");
                break;
                
                        
                }
                
                
                if(opcao == 1){
                    veiculo.Add(Console.ReadLine()!);
                }else if(opcao == 2){
                    veiculo.Remove(Console.ReadLine()!);
                    Console.WriteLine($"quanto tempo ficou o carro?");
                    try{
                    int resultado = Convert.ToInt32(Console.ReadLine()) * 2 + 5;
                    Console.WriteLine($"Carro retirado!! valor é de R${resultado}");    
                    }catch{
                    Console.WriteLine("valor invalido"); 
                    }
                }else if(opcao == 3){
                    foreach(string contagem in veiculo){
                          
                          Console.WriteLine($"placa - {contagem}");
                    }Console.WriteLine($"total {veiculo.Count} de veiculos estacionados");
                    
                }else if(opcao == 4){
                    fechar = false;
                }else{}
                Console.WriteLine("aperte qualquer tecla para dar ok");
                Console.ReadKey();
                
           Console.Clear();
            
            }


        }

    }
}