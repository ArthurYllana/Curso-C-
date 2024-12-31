namespace Estrutura
{
    // Definição da classe Point
    class Point
    {
        // Propriedades X e Y
        public int X { get; set; }
        public int Y { get; set; }

        // Sobrescrita do método ToString
        public override string ToString()
        {
            return $"Point(X: {X}, Y: {Y})";
        }
    }
}