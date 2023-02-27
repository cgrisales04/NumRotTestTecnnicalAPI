using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NumRotTestTecnnicalAPI.Persistence.Entity;
using NumRotTestTecnnicalAPI.Persistence.Entity.DataTransferObjects;
using NumRotTestTecnnicalAPI.Persistence.Repository.Wrapper;

namespace NumRotTestTecnnicalAPI.Controllers {

    [Route("api/infousers")]
    [ApiController]
    public class InfoUsersController : ControllerBase {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public InfoUsersController(IRepositoryWrapper repository, IMapper mapper) {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllInfoUsers() {
            try {
                var findInfoUsers = _mapper.Map<IEnumerable<InfoUserDto>>(_repository.InfoUser.GetAllInfoUsers());
                if (findInfoUsers is null) {
                    return Ok(ResponseFactory.Crear(false, "¡Info Users not found!", findInfoUsers));
                }
                return Ok(ResponseFactory.Crear(true, "¡Info Users found successfully!", findInfoUsers));
            } catch (Exception ex) {
                return StatusCode(500, ex + "Internal server error");
            }
        }


        [HttpGet("{id}")]
        public IActionResult GetInfoUsersById(int id) {
            try {
                var info_user = _repository.InfoUser.GetInfoUsersById(id);
                if (info_user is null) {
                    return Ok(ResponseFactory.Crear(false, "¡Info User not found!", info_user));
                } else {
                    return Ok(ResponseFactory.Crear(true, "¡Info User found successfully!", _mapper.Map<InfoUserDto>(info_user)));
                }
            } catch (Exception ex) {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        public IActionResult CreateInfoUsers([FromBody] InfoUsersForCreationDto infoUsers) {
            try {
                if (infoUsers is null) {
                    return Ok(ResponseFactory.Crear(false, "Please enter a values corrects.", ""));
                }
                if (!ModelState.IsValid) {
                    return getErrors();
                }
                var findInfoUsers = _repository.InfoUser.GetInfoUsersByIdentification(infoUsers.identification);
                if (findInfoUsers != null) {
                    return Ok(ResponseFactory.Crear(false, "User existing with this identification.", ""));
                }

                var infoUsersEntity = _mapper.Map<InfoUsers>(infoUsers);
                _repository.InfoUser.CreateInfoUsers(infoUsersEntity);
                _repository.Save();
                var createdInfoUser = _mapper.Map<InfoUsers>(infoUsersEntity);
                return Ok(ResponseFactory.Crear(
                    true,
                    "User created successfully.",
                    CreatedAtRoute("InfoUserById", new { id = createdInfoUser.info_user_id }, createdInfoUser).Value)
                    );

            } catch (Exception ex) {
                return StatusCode(500, "Internal server error");
            }
        }


        [HttpPut("{id}")]
        public IActionResult UpdateInfoUsers(int id, InfoUsersForCreationDto infoUsersForCreationDto) {
            try {
                if (infoUsersForCreationDto is null) {
                    return Ok(ResponseFactory.Crear(false, "Please enter a values corrects.", ""));
                }
                if (!ModelState.IsValid) {
                    return getErrors();
                }

                var findInfoUsers = _repository.InfoUser.GetInfoUsersByIdNotJoin(id);
                if (findInfoUsers == null) {
                    return Ok(ResponseFactory.Crear(false, "User not existing with this id.", ""));
                }

                _mapper.Map(infoUsersForCreationDto, findInfoUsers);
                _repository.InfoUser.UpdateInfoUsers(findInfoUsers);
                _repository.Save();
                return Ok(ResponseFactory.Crear(true, "User update successfully.", findInfoUsers));
            } catch (Exception ex) {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteInfoUsers(int id) {
            try {
                var infoUsers = _repository.InfoUser.GetInfoUsersById(id);
                if (infoUsers == null) {
                    return Ok(ResponseFactory.Crear(false, "User not existing with this id.", ""));
                }
                _repository.InfoUser.DeleteInfoUsers(infoUsers);
                _repository.Save();
                return Ok(ResponseFactory.Crear(true, "User deleted successfully.", infoUsers));
            } catch (Exception ex) {
                return StatusCode(500, "Internal server error");
            }
        }

        private IActionResult getErrors() {
            return Ok(ModelState
           .Where(x => x.Value.Errors.Any())
           .ToDictionary(x => x.Key, x => x.Value.Errors.Select(error => error.ErrorMessage)));
        }

    }
}

