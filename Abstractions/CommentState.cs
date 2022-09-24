namespace PreventChangeEntityAfterOnce.Abstractions
{
    public interface ICommentState
    {
        void Modify(string body);
        void Modify2(string body);
        void Modify3(string body);
    }
}
