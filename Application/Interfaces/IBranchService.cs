using Domain.Models;

namespace Application.Interfaces;

public interface IBranchService
{
    bool CreateBranch(Branch branch);
    List<Branch> getBranches();
    bool UpdateBranch(Branch branch);
    bool DleteBranch(int id);
}