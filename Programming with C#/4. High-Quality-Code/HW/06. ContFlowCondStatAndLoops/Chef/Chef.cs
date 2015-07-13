namespace Chef
{
    using System;

    public class Chef
    {
        public void Cooc()
        {
            Bowl bowl = GetBowl();
            Carrot carrot = GetCarrot();
            Patato patato = GetPatato();

            this.Peel(patato);
            this.Peel(carrot);

            this.Cut(patato);
            this.Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(patato);
        }

        private static Bowl GetBowl()
        {
            throw new NotImplementedException("TODO");
        }

        private static Carrot GetCarrot()
        {
            throw new NotImplementedException("TODO");
        }

        private static Patato GetPatato()
        {
            throw new NotImplementedException("TODO");
        }

        private void Peel(Vegetables vegetables)
        {
            throw new NotImplementedException("TODO");
        }

        private void Cut(Vegetables vegetables)
        {
            throw new NotImplementedException("TODO");
        }
    }
}