using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Text;

namespace Dsw2026Ej8
{
    public class Product
    {
        private int _code;
        private string _description;
        private bool _active;
        private double _price;
        private float _tax;
        private int _stock;
        private char _presentation;
        private DateTime _date;
        private bool _internal;


        public Product(int code, string description, double price, char presentation)
        {
            _code = code;
            _description = description;
            _price = price;

            char[] validPresentation = { 'I', 'S', 'K', 'E', 'P' };
            if (validPresentation.Contains(presentation))
            {
                _presentation = presentation;

            }
            else
            {
                _presentation = 'I';
            }

            _tax = 0.21f;
            _stock = 0;
            _active = true;
            _internal = false;
            _date = DateTime.Now;

        }

        public int GetCode()
        {
            return _code;
        }
        public string GetDescription()
        {
            return _description;
        }

        public bool GetActive()
        {
            return _active;
        }

        public double GetPrice()
        {
            return _price;
        }

        public float GetTax()
        {
            return _tax;
        }
        public void SetTax(float tax)
        {
            _tax = tax;
        }

        public int GetStock()
        {
            return _stock;
        }

        public char GetPresentation()
        {
            return _presentation;
        }
        public DateTime GetDate()
        {
            return _date;
        }
        public bool GetInternal()
        {
            return _internal;
        }
        public void SetInternal(bool internalValue)
        {
            _internal = internalValue;
        }


        public void Deactivate()
        {
            _active = false;
        }

        public double GetFinalPrice()
        {

            return _price + (_price * _tax);
        }

        public string GetDetailedInfo()
        {
            string _mensajeStock = string.Empty;

            if (_active && _stock > 0)
            {
                _mensajeStock = "Disponible";
            }
            else if (!_active)
            {
                _mensajeStock = "No disponible";
            }
            else if (_active && _stock == 0)
            {
                _mensajeStock = "Sin Stock";
            }

            return $"[{_code}], Description [{_description}]: Price: {_price.ToString("C")} - {_mensajeStock}";
        }

        public void IncreaseStock() =>++_stock;

        public void DecreaseStock()
        {
            if (_stock > 0)
            {
                --_stock;
            }
        }

        public void IncreaseStock(int valor)
        {
            _stock += valor;
        }

        public double GetPricePerFraction(int fraction)
        {
            if (_presentation == 'K' && fraction > 0)
            {
                return _price / fraction;
            }
            else
            {
                return 0;
            }
        }

        public string GetPackaging()
        {
            switch (_presentation)
            {

                case 'I':
                    return "Envase Individual";
                case 'S':
                    return "Enpaque Secundario";
                case 'K':
                    return "Pack";
                case 'E':
                    return "Eco-Friendly";
                case 'P':
                    return "Premium";
                default:
                    return "Desconocida";
            }

        }

        public void Update(string descripcion) {
            _description = descripcion;
        }

        public void Update(string descripcion,double price)
        {
            _description = descripcion;
            if(price != 0)
            {
                _price = price;
            }

        }

        public void Update(string descripcion, float tax)
        {
            _description = descripcion;
            if (_tax != tax)
            {
                _tax = tax;
            }
        }

        public void Update(string descripcion, double price, float tax)
        {
            _description = descripcion;

            if (price != 0)
            {
                _price = price;
            }

            if (_tax != tax)
            {
                _tax = tax;
            }
        }
    }
}

