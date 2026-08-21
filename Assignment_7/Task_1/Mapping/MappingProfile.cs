using AutoMapper;
using Task_1.DTOs;
using Task_1.Models;

namespace Task_1.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Tasks, TaskItemDTO>();

            CreateMap<TaskItemDTO, Tasks>();

            CreateMap<Tasks, CreateTaskRequestDTO>();

            CreateMap<CreateTaskRequestDTO, Tasks>();

            CreateMap<Tasks, UpdateTaskRequestDTO>();

            CreateMap<UpdateTaskRequestDTO, Tasks>();

        }
    }
}
