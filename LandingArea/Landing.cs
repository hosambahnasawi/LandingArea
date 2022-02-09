using System;

namespace LandingArea
{
    public class Landing
    {
        int[,] LandingPlatform;

        private static readonly Lazy<Landing> Instance = new Lazy<Landing>(() => new Landing());

        public static Landing GetInstance
        {
            get
            {
                return Instance.Value;
            }
        }
        private Landing()
        {
            LandingPlatform = new int[100, 100];
            for (int i = 0; i < LandingPlatform.GetLength(0); i++)
            {
                for (int j = 0; j < LandingPlatform.GetLength(1); j++)
                {
                    LandingPlatform[i, j] = (int)Position.CorrectPosition;
                }
            }
        }
        public string canLand(int x, int y)
        {
            if (x < 5 || x > 15 || y < 5 || y > 15)
                return "Out Of Platform";
            switch (LandingPlatform[x, y])
            {
                case (int)Position.CorrectPosition:
                    return "Ok Landing";
                case (int)Position.InCorrectPosition:
                case (int)Position.PreviousRocket:
                    return "Clash";
                default:
                    return "Out Of Platform";
            }
        }
        public void LandRocket(int x, int y)
        {
            LandingPlatform[x, y] = (int)Position.PreviousRocket;
            LandingPlatform[x - 1, y] = (int)Position.InCorrectPosition;
            LandingPlatform[x + 1, y] = (int)Position.InCorrectPosition;
            LandingPlatform[x, y - 1] = (int)Position.InCorrectPosition;
            LandingPlatform[x, y + 1] = (int)Position.InCorrectPosition;
        }

    }
    enum Position
    {
        CorrectPosition,
        InCorrectPosition,
        PreviousRocket
    }
    enum PositionValue
    {
        OutOfPlatform,
        Clash,
        OkLanding
    }
}
