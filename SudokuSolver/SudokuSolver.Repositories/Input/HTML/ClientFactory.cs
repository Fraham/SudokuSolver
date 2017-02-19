using System;
using System.Configuration;

namespace SudokuSolver.Repositories.Input.HTML
{
    public static class ClientFactory
    {
        private static string READER_MODE_KEY = "htmlMode";

        public static IHTMLClient GetClient(FakeEnum fakeEnum = FakeEnum.NotSet)
        {
            if (fakeEnum == FakeEnum.NotSet && ConfigurationManager.AppSettings[READER_MODE_KEY] != null)
            {
                Enum.TryParse(ConfigurationManager.AppSettings[READER_MODE_KEY], out fakeEnum);
            }

            switch (fakeEnum)
            {
                case FakeEnum.Fake:
                    return new HTMLFake();

                default:
                    return new HTMLClient();
            }
        }
    }
}
