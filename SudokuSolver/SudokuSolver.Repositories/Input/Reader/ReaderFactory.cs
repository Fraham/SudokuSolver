using System;
using System.Configuration;

namespace SudokuSolver.Repositories.Input.Reader
{
    public static class ReaderFactory
    {
        private const string READER_MODE_KEY = "readerMode";

        public static IReader GetReader(FakeEnum fakeEnum = FakeEnum.NotSet)
        {
            if (fakeEnum == FakeEnum.NotSet && ConfigurationManager.AppSettings[READER_MODE_KEY] != null)
            {
                Enum.TryParse(ConfigurationManager.AppSettings[READER_MODE_KEY],out fakeEnum);
            }

            switch (fakeEnum)
            {
                case FakeEnum.Fake:
                    return new ReaderFake();

                default:
                    return new ReaderConcrete();
            }
        }
    }
}
