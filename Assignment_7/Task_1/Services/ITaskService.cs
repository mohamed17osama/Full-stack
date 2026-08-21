using Task_1.DTOs;
using Task_1.Models;

namespace Task_1.Services
{
    public interface ITaskService
    {
        public Task<CreateTaskRequestDTO> CreateTask(CreateTaskRequestDTO task);

        public Task<PageResult<Tasks>> GetAll(TaskFilterParam param);

        public Task<TaskItemDTO> GetTaskById(int id);

        public Task<UpdateTaskRequestDTO> UpdateTask(int id, UpdateTaskRequestDTO task);

        public Task<string> DeleteTask(int id);
    }
}
