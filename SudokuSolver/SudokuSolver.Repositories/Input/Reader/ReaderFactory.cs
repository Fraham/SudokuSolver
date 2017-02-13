namespace SudokuSolver.Repositories.Input.Reader
{
    public static class ReaderFactory
    {
        public static IReader GetReader(FakeEnum fakeEnum = FakeEnum.Real)
        {
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
