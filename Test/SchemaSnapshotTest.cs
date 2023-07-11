using HotChocolate.Execution;
using Microsoft.Extensions.DependencyInjection;
using Snapshooter.Xunit;
using Xunit;

namespace Test
{
    public class SchemaSnapshotTest
    {
        [Fact]
        public async Task GenerateSchema_CompareWithSnapshot()
        {
            try
            {
                // Arrange
                var schema = await new ServiceCollection()
                    .AddGraphQLServer()
                    .AddTypes()
                    .BuildSchemaAsync();

                // Act & Assert
                schema.ToString().MatchSnapshot();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
