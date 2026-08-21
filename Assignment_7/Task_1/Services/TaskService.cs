using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Task_1.DTOs;
using Task_1.Models;
using Task_1.Repositories;

namespace Task_1.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _repo;
        private IMapper _mapper;

        public TaskService(ITaskRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<CreateTaskRequestDTO> CreateTask(CreateTaskRequestDTO task)
        {
            var Taskmodel = _mapper.Map<Tasks>(task);

            var TaskFound = await _repo.CreateTask(Taskmodel);

            var TaskDTO = _mapper.Map<CreateTaskRequestDTO>(TaskFound);
            return TaskDTO;

        }

        public async Task<string> DeleteTask(int id)
        {
            return await _repo.DeleteTask(id);
        }

        public async Task<PageResult<Tasks>> GetAll(TaskFilterParam param)
        {
            return await _repo.GetAll(param);
        }

        public async Task<TaskItemDTO> GetTaskById(int id)
        {
            var TaskModel = await _repo.GetTaskById(id);

            var TaskDTO = _mapper.Map<TaskItemDTO>(TaskModel);

            return TaskDTO;
        }

        public async Task<UpdateTaskRequestDTO> UpdateTask(int id, UpdateTaskRequestDTO task)
        {
            var TaskModel = _mapper.Map<Tasks>(task);

            var TaskFound = await _repo.UpdateTask(id, TaskModel);

            var TaskDTO = _mapper.Map<UpdateTaskRequestDTO>(TaskFound);

            return TaskDTO;
        }
    }
}
