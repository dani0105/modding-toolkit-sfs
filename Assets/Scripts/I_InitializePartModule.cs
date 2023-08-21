// I_InitializePartModule
namespace SFS
{
    public interface I_InitializePartModule
    {
        int Priority { get; }

        void Initialize();
    }
}