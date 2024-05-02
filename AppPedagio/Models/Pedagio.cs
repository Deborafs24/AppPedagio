using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPedagio.Models
{
    public class Pedagio
    {
        public string _Origem {get; set;}
        public string _Destino { get; set;}
        public string Local { get; set;}
        public double Valor { get; set;}
        public double _Distancia {  get; set;}
        public double _Rendimento {  get; set;}
        public double _Precogas {  get; set;}

        public string Origem 
        {
            get => _Origem;
            set
            {
                if (value == null)
                    throw new Exception("Origem inválida.");

                _Origem = value;
            }
        }

        public string Destino
        {
            get => _Destino;
            set
            {
                if (value == null)
                    throw new Exception("Destino incorreto.");

                _Destino = value;
            }
        }

        public double Distancia
        {
            get
            {
                return _Distancia;
            }

            set
            {
                if (!double.TryParse(value.ToString(), out _Distancia))
                    _Distancia = 0;

                if (value == 0)
                    throw new Exception("Opção inválida.");

                _Distancia = value;
            }
        }

        public double Rendimento
        {
            get
            {
                return _Rendimento;
            }

            set
            {
                if (!double.TryParse(value.ToString(), out _Rendimento))
                    _Rendimento = 0;

                if (value == 0)
                    throw new Exception("Opção inválida.");

                _Rendimento = value;
            }
        }

        public double Precogas
        {
            get
            {
                return _Precogas;
            }

            set
            {
                if (!double.TryParse(value.ToString(), out _Precogas))
                    _Precogas = 0.0;

                if (value == 0)
                    throw new Exception("Preço inválido.");

                _Precogas = value;
            }
        }
    }
}
