using PreventChangeEntityAfterOnce.Abstractions;
using PreventChangeEntityAfterOnce.Entities;

namespace PreventChangeEntityAfterOnce.EntitiesStates.CommentEntityStates
{
    public class CommentChangedState : ICommentState
    {
        private readonly Comment _comment;

        public CommentChangedState(Comment comment)
        {
            _comment = comment;
        }

        public void Modify(string body)
        {
            // do nothing ...

            // event we can throw an exception if we want :D it's depend on our design
        }

        public void Modify2(string body)
        {
        }

        public void Modify3(string body)
        {
        }
    }
}
