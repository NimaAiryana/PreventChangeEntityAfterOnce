using PreventChangeEntityAfterOnce.Abstractions;
using PreventChangeEntityAfterOnce.Entities;

namespace PreventChangeEntityAfterOnce.EntitiesStates.CommentEntityStates
{
    public class CommentBeforeChangesState : ICommentState
    {
        private readonly Comment _comment;

        public CommentBeforeChangesState(Comment comment)
        {
            _comment = comment;
        }

        public void Modify(string body)
        {
            _comment.Body = body;

            // some other logics ...

            _comment.ChangeState(_comment.ChangedState);
        }

        public void Modify2(string body)
        {
            _comment.Body = body;

            _comment.ChangeState(_comment.ChangedState);
        }

        public void Modify3(string body)
        {
            _comment.Body = body;

            _comment.ChangeState(_comment.ChangedState);
        }
    }
}
