namespace Ignite {
    public static class Extensions {
        public static TResult Pipe<TInput, TResult> (this TInput input, System.Func<TInput, TResult> function)
            => function (input);
        public static void Pipe<TInput> (this TInput input, System.Action<TInput> action)
            => action (input);
    }
}