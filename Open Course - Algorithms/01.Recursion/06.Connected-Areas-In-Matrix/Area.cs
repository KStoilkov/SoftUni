namespace _06.Connected_Areas_In_Matrix
{
    using System;

    public class Area : IComparable<Area>
    {
        public Area(int size, int row, int col)
        {
            this.Size = size;
            this.Row = row;
            this.Col = col;
        }

        public int Size { get; set; }

        public int Row { get; set; }

        public int Col { get; set; }

        public int CompareTo(Area area)
        {
            return this.Size > area.Size ? this.Size : area.Size;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}), Size: {2}", this.Row, this.Col, this.Size);
        }
    }
}