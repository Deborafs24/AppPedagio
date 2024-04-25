using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPedagio.Models
{
    public class Pedagio
    {
        string _origem;
        string _destino;
        double _distancia;
        double _rendimento;
        double _precogas;

        public int Id { get; set; }

        public string Origem
        {
            get => _origem;
            set
            {
                if (value == null)
                    throw new Exception("Origem inválida.");

                _origem = value;
            }
        }

        public string Destino
        {
            get => _destino;
            set
            {
                if (value == null)
                    throw new Exception("Destino incorreto.");

                _destino = value;
            }
        }

        public double Distancia
        {
            get
            {
                return _distancia;
            }

            set
            {
                if (!double.TryParse(value.ToString(), out _distancia))
                    _distancia = 0;

                if (value == 0)
                    throw new Exception("Opção inválida.");

                _distancia = value;
            }
        }

        public double Rendimento
        {
            get
            {
                return _rendimento;
            }

            set
            {
                if (!double.TryParse(value.ToString(), out _rendimento))
                    _rendimento = 0;

                if (value == 0)
                    throw new Exception("Opção inválida.");

                _rendimento = value;
            }
        }

        public double Precogas
        {
            get
            {
                return _precogas;
            }

            set
            {
                if (!double.TryParse(value.ToString(), out _precogas))
                    _precogas = 0.0;

                if (value == 0)
                    throw new Exception("Preço inválido.");

                _precogas = value;
            }
        }
    }
}
