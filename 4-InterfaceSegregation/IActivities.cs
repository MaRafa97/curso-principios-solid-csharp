namespace InterfaceSegregation
{
    // cada tipo de usuario o persona en el proyecto puede tener sus actividades
    // especificas, sin repetir, heredar multiples interfaces conforme sea necesario
    public interface IActivities
    {
        void Plan();
        void Comunicate();
        void Design();
        void Develop();
        void Test();
    }
}