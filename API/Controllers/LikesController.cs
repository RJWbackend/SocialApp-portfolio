using System;
using API.DTOs;
using API.Extensions;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class LikesController(ILikesRepository likesRepository) : BaseApiController
{
    [HttpPost("{targetUserId:int}")]// liking or unliking someone
    public async Task<ActionResult> Togglelike(int targetUserId)
    {
        var sourceUserId = User.GetUserId();

        if (sourceUserId == targetUserId) return BadRequest("You cannot like yourself");

        var existingLike = await likesRepository.GetUserLike(sourceUserId, targetUserId);

        if (existingLike == null)
        {
            var like = new UserLike
            {
                SourceUserId = sourceUserId,
                TargetUserId = targetUserId
            };

            likesRepository.AddLike(like);
        }
        else
        {
            likesRepository.DeleteLike(existingLike);
        }

        if (await likesRepository.SaveChanges()) return Ok();

        return BadRequest("Failed to like user");
    }


    [HttpGet("list")] // getting list of people you liked

    public async Task<ActionResult<IEnumerable<int>>> GetCurrentUserLikeIds()
    {
         return Ok(await likesRepository.GetCurrentUserLikeIds(User.GetUserId())); 
    }

    [HttpGet] // getting list of likes

    public async Task<ActionResult<IEnumerable<MemberDto>>> GetUserLikes(string predicate)
    {
        var users = await likesRepository.GetUserLikes(predicate, User.GetUserId());

        return Ok(users);
    }
}
