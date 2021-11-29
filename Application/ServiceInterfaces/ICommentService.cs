using Application.Dtos.DtoOther;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceInterfaces
{
    public interface ICommentService
    {
        CommentDto CreateComment(CreateCommentDto newComment);
        bool RemoveComment(int id);
    }
}
