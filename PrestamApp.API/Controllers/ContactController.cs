using Microsoft.AspNetCore.Mvc;
using PrestamApp.Application.Contacts.Commands.CreateContact;
using PrestamApp.Application.Contacts.Commands.DeleteContact;
using PrestamApp.Application.Contacts.Commands.UpdateContact;
using PrestamApp.Application.Contacts.Queries.GetContactDetail;
using PrestamApp.Application.Contacts.Queries.GetContactList;
using System.Threading.Tasks;

namespace PrestamApp.API.Controllers
{
    public class ContactController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<ContactDto>> Get()
        {
            return Ok(await Mediator.Send(new GetContactListQuery()));
        }

        [HttpGet]
        public async Task<ActionResult<ContactDetailDto>> GetDetail(int id)
        {
            return Ok(await Mediator.Send(new GetContactDetailQuery { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateContactCommand command)
        {
            await Mediator.Send(command);
            return Ok(command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] UpdateContactCommand command)
        {
            await Mediator.Send(command);
            return Ok(command);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteContactCommand { Id = id });
            return Ok("Cliente eliminado exitosamente");
        }



    }
}
