using Solo.Interfaces;

namespace Solo.Models.Crystals
{
    public class Crystal
    {
        private readonly IColor _color;


        public Crystal(IColor color)
        {
            _color = color;
        }

        public override bool Equals(object obj)
        {
//            return obj is Crystal crystal && Equals(crystal);
            return true;
        }

//        private bool Equals(Crystal other)
//        {
//            return _color
//        }

        public override int GetHashCode()
        {
            return (_color != null ? _color.GetHashCode() : 0);
        }
    }
}