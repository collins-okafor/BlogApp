using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class AddRefreshTokenTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JwtId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    IsRevoked = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Alfred Reilly");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Dexter Raynor");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Roman Lind");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Lucas Mann");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Lynette Wiegand");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Josefina Wolff");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Jake Harvey");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Kenny Olson");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Elmer Nienow");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Mabel Barrows");

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 3, "Iste nihil similique molestiae dignissimos ut.\nTempore esse voluptatibus recusandae.\nUt nesciunt molestiae quos id suscipit voluptatibus consequatur quae.\nFugit placeat nesciunt quis aut.\nConsectetur voluptas tempore eos aut.\nRerum autem quibusdam architecto iste placeat vel nobis qui.\nCupiditate consequatur minima.\nTempora quibusdam soluta illo aut necessitatibus qui.\nEnim qui enim architecto.\nSaepe atque est enim architecto a.", new DateTime(2022, 10, 14, 9, 36, 51, 254, DateTimeKind.Local).AddTicks(8885), "Quis iure explicabo cumque." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 2, "Ut et ea tempora architecto tempora ut explicabo dolore.\nReprehenderit vitae et.\nAsperiores quia cumque et aut et atque veniam.\nVelit quos qui ducimus pariatur dicta.\nQuia aspernatur voluptatem ad debitis.\nExplicabo a ut mollitia et reiciendis.\nFugiat sunt error eligendi.\nDelectus et in maiores est.\nExercitationem tenetur rerum neque minus nisi omnis et.\nSapiente rerum exercitationem.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(253), "Ad illo optio provident." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 10, "Eum vel debitis quas veritatis et aut non.\nConsequuntur aut eius.\nAmet autem quam voluptatibus molestiae excepturi non modi.\nIllum nihil ut quaerat hic quibusdam harum aliquid qui et.\nFugiat nesciunt nisi at temporibus necessitatibus exercitationem ab.\nCorporis et et temporibus aliquam optio et sint ea.\nVoluptatem corporis occaecati itaque natus blanditiis sed et nihil ipsam.\nEst tempore qui qui officiis.\nDoloremque error consectetur.\nEius debitis esse.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(1432), "Laboriosam officiis sed incidunt." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 6, "Officiis fugit doloribus quas velit.\nIpsam modi repellendus qui aliquam.\nDeserunt id molestias.\nReiciendis dolorem quia vel libero necessitatibus hic.\nRepudiandae et nihil aut.\nQui et ex quibusdam qui.\nSit optio ipsum ipsa magnam iste.\nDolore ipsum recusandae rerum et qui voluptates ut amet.\nUt fuga qui maiores dolorem qui officia est.\nNumquam officiis reprehenderit maxime ut nostrum eos ullam quia et.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(1910), "Dolorem aut dolor consequatur." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 9, "Dolor ut ut quia minima consectetur vel quia.\nEum ipsum accusamus.\nSit officiis culpa iusto laboriosam nisi.\nVero nihil aperiam expedita corrupti voluptas qui quae vel sint.\nAut quisquam nisi.\nOfficia dolorum iusto harum voluptatem dolores.\nMinus sint sed enim.\nNemo ab tempora est dolorum voluptatum recusandae temporibus ex.\nEnim nobis odio est.\nDolorem quos quis consequatur voluptatem.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(2307), "Quia a qui et." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 2, "Voluptatem iusto tempore est occaecati ut eius repellat.\nRepellat voluptatem eum reprehenderit voluptas.\nOmnis doloremque reprehenderit enim facere consectetur esse neque ea.\nRatione placeat quia minus.\nVoluptas ut est repudiandae nesciunt dolores sed nam.\nEst laudantium odio sit suscipit cum nam reiciendis.\nCommodi iste animi.\nEst dolore sint et ad ipsam ducimus quis temporibus aspernatur.\nMollitia incidunt aut eos deleniti.\nNostrum iusto commodi quo.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(2684), "Harum veniam a repellat." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 6, "In ipsum impedit possimus quia beatae officiis dolorum.\nIn magnam modi aut eius nemo.\nConsequatur dolor minus aut autem non et accusamus architecto quia.\nDolor fugit a omnis.\nDucimus harum accusamus sed beatae laboriosam dicta occaecati ex.\nEligendi beatae sint quasi harum.\nEa omnis et sunt.\nQuisquam rerum ab libero quo.\nIllo voluptas optio quas corrupti quidem et est.\nUt aut et accusantium.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(3079), "Quis facere vitae dolorem." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 1, "Tenetur consequatur corrupti sunt est natus.\nConsectetur rem qui.\nQui sed labore expedita doloremque cum distinctio possimus.\nOdio corrupti exercitationem laudantium.\nCorporis est eveniet deleniti dolores aut ex numquam dolore.\nSoluta similique facere et rerum qui ducimus a quae molestiae.\nSimilique nam consequatur inventore sed dicta est.\nVoluptatibus totam impedit accusantium nostrum rem voluptates dolores.\nLaboriosam facere reprehenderit id quis ex reiciendis laudantium.\nId consequatur facere asperiores provident magnam aperiam ad minus maiores.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(3469), "Numquam placeat provident fugiat." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 6, "Ut quam ut perspiciatis laudantium qui aperiam.\nId et nostrum eaque et.\nNemo reprehenderit mollitia laborum ut.\nDebitis maiores itaque blanditiis doloribus sit quod molestiae id quis.\nEt consequatur sit sit itaque aut et laudantium.\nEst iusto aliquam repudiandae sapiente.\nEx ducimus cum eos dolorem maiores ut et quo veniam.\nExcepturi omnis dignissimos quo aut impedit.\nDebitis nihil tempora ut voluptatem quis.\nTempore ratione inventore amet odio qui.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(3929), "Quam mollitia rerum culpa." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Body", "TimeStamp", "Title" },
                values: new object[] { "Totam praesentium facere voluptas consectetur.\nId blanditiis dolores consequatur sit.\nNam est aut aperiam sed est qui.\nCorporis possimus sequi quo.\nEt enim omnis blanditiis sit error.\nQuam eos et doloribus quia aspernatur eaque mollitia cupiditate.\nRerum nemo magni atque cupiditate quo et doloribus sapiente eius.\nAut rerum impedit nemo.\nNulla omnis aperiam amet repellat deleniti aut ut sequi aut.\nIllum voluptates odio minus vero distinctio.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(4376), "Dolores doloribus nam nostrum." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 4, "Iste et totam illo ut sunt voluptatem repudiandae sed soluta.\nMagnam ad natus laboriosam.\nVoluptate quas saepe voluptas quisquam ut odit beatae occaecati atque.\nDignissimos natus quo praesentium quia.\nAt deleniti iste provident nihil blanditiis nam quo necessitatibus.\nDolores cumque amet praesentium ullam voluptatem rem laudantium nisi vel.\nAmet quia cupiditate iure provident et eius officiis.\nCumque eius alias ea quam.\nRepellendus iure voluptatibus.\nIncidunt corrupti eum.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(4839), "Officiis nulla impedit repellat." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 3, "Quia sunt quis.\nQui quia libero.\nDoloremque qui necessitatibus deserunt.\nSapiente sed et sint cumque dolor.\nEius sed vitae.\nUllam qui amet ea aperiam iste.\nVelit voluptas neque.\nUt sit aut est incidunt facere molestiae facere dolore.\nQui repellendus cupiditate.\nQuae ab cum iste maiores.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(5241), "Ut autem suscipit accusantium." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 9, "Doloribus enim quia voluptatum magni eligendi facere veniam non.\nRepudiandae illum explicabo omnis veniam.\nDolor quo iure nulla quibusdam.\nVeritatis doloribus quas suscipit facilis at voluptas dolorem.\nOdio minima quibusdam labore dignissimos.\nMinima fugit ea cumque quas ipsam accusantium dolores ut.\nAlias cumque perspiciatis aut dolorem quas reiciendis.\nSit dolore dolores.\nAutem ab ut tenetur ipsa consequatur rem sed exercitationem enim.\nCorrupti quas quisquam voluptatibus qui exercitationem nisi eaque at.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(5548), "Qui consequatur necessitatibus qui." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Body", "TimeStamp", "Title" },
                values: new object[] { "Explicabo itaque corporis repellendus voluptates.\nTempore nemo quia ex.\nOmnis ad sit distinctio cumque quis eligendi eos illo.\nDucimus occaecati fugiat porro maiores.\nMinima nihil ipsa velit.\nDolorem cum repudiandae provident incidunt excepturi in facilis illum.\nIn et nisi maxime.\nSit adipisci similique.\nRerum quis qui veritatis facilis quam.\nEt molestiae maiores reprehenderit animi veniam.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(5966), "Facere rerum voluptatem repellendus." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 10, "Totam est exercitationem numquam.\nAut quae necessitatibus quos.\nRepudiandae consectetur vitae dolores sunt laudantium praesentium odio et ut.\nOmnis ducimus voluptatum.\nNihil mollitia sed nobis nostrum commodi voluptatum repudiandae.\nAut optio et.\nCorrupti sapiente animi.\nReiciendis sunt perferendis autem nemo totam impedit.\nOfficia earum reiciendis quo aut impedit.\nQui iste vel quas non.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(6314), "Ab eum mollitia odit." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 3, "Aperiam debitis vel.\nHic et libero qui dolor ea.\nEt fugit magni voluptate quia nihil.\nDolores architecto illo reprehenderit quis fugiat.\nCum blanditiis libero voluptas dolor deleniti in.\nNostrum et fugiat libero velit doloribus voluptas.\nMolestiae molestiae delectus ea.\nOptio autem occaecati repellat quos consectetur itaque quia.\nRerum quas reiciendis accusamus ad adipisci repellat quaerat repellat aut.\nUt dolorem optio in ut quas et ipsum ut et.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(6665), "Velit laborum iusto minima." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 5, "Voluptatem voluptas quis.\nQuidem enim sit autem voluptas.\nSit quo magni ipsum dolorem molestiae dicta voluptatum.\nOfficiis cum earum praesentium maiores.\nAssumenda corporis sit quia aspernatur quas ipsa ullam fugit.\nRecusandae impedit deserunt dolore eaque dolores et magnam pariatur.\nPorro eaque minus praesentium.\nQuia alias corrupti aut ea quia et.\nCupiditate accusamus aut repellat et.\nSit nostrum esse sit.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(7063), "Voluptate voluptatum eum reiciendis." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 4, "Vel est eligendi est vel.\nQui similique accusamus.\nOmnis quas omnis velit impedit rerum et velit.\nVel doloremque dolores.\nVoluptatem libero rerum corporis voluptatem.\nTempora voluptas eum est sit est.\nSint quaerat corrupti voluptatum eos odio consequuntur maiores.\nCum id numquam nemo nobis ipsum.\nNihil pariatur ad aut atque libero earum non maxime.\nNeque facilis nemo rerum minus quis voluptatum beatae.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(7436), "Ut numquam quos tempora." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 2, "Quis corporis sunt asperiores ratione dicta porro.\nInventore occaecati voluptate molestiae et voluptas ratione pariatur.\nIste minus et ad atque.\nQuas earum consequatur quod tempora error ea aut.\nLaborum nobis excepturi sit aspernatur rerum repellendus distinctio doloribus.\nQui temporibus ut consequatur laudantium harum.\nEnim quos consequatur eos aut ipsam necessitatibus fuga et ab.\nNisi corrupti nesciunt optio quidem culpa enim modi voluptas.\nFacere quis est architecto dignissimos fugiat eveniet necessitatibus delectus dolores.\nAut ullam nostrum accusamus sint ut aut quis fuga iste.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(7811), "Consequatur et deserunt labore." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 1, "Necessitatibus voluptatem sapiente dolores et.\nSapiente occaecati sed deserunt repellendus.\nDeleniti doloribus minus aut repudiandae.\nUt consectetur et dolorem sed est molestias pariatur cumque velit.\nRem est possimus earum unde consequatur quod alias.\nDistinctio et suscipit assumenda placeat molestiae sit dignissimos.\nHarum qui non voluptatibus quia vitae enim quam veritatis doloremque.\nDoloribus reprehenderit id omnis et.\nQui doloremque quam recusandae voluptatibus asperiores aspernatur ad.\nEt vero explicabo beatae.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(8281), "Eveniet alias ipsam et." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 2, "Autem quos est tempore harum consequuntur rerum.\nEt est ut velit dolor ut aut odit.\nAccusantium a est dolorem.\nNihil et et blanditiis quia maiores quo molestiae molestiae.\nSed sapiente consequatur nesciunt ipsum ex.\nAut eaque quis dignissimos et tenetur ut architecto consequuntur.\nSunt ad aperiam repellat quam voluptas sapiente repellendus maxime voluptatem.\nAut sapiente accusamus qui.\nEum distinctio illum delectus rerum recusandae quibusdam labore.\nLaborum sed eum beatae.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(8703), "Molestiae veritatis a quasi." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 10, "Et necessitatibus iusto sed velit ipsa quis molestiae.\nEst alias architecto esse porro.\nQuia in quaerat neque accusantium sequi voluptatum quibusdam pariatur aut.\nCulpa impedit autem id.\nId hic quia beatae fugiat qui ut dolorum et.\nQuas laudantium et voluptatem ut quia libero.\nEum voluptas sed eaque.\nDeserunt quia explicabo officia ipsam aut laudantium nam quidem minus.\nIn quia exercitationem rerum quasi est aperiam rerum labore.\nEst perferendis dolorem cumque ut odit.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(9112), "Esse vel velit aut." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 10, "Delectus provident ut id consequatur tempora facilis.\nRepudiandae accusamus minus illum placeat esse.\nDoloremque aut odit consequatur deleniti quibusdam provident earum neque.\nNecessitatibus quae et iste magni tempore ut magni fugiat nesciunt.\nId suscipit sint aut asperiores repellendus ut dolor veniam.\nHic at minima aut et.\nHic velit assumenda iusto officia quod consequatur sint dolor.\nUt repellendus adipisci omnis nobis sint quaerat veritatis nostrum.\nAmet consequatur corrupti perferendis doloribus neque debitis culpa itaque.\nOfficia tempore optio illum.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(9540), "Sed sapiente omnis cum." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Body", "TimeStamp", "Title" },
                values: new object[] { "Non alias fuga numquam aut possimus qui cupiditate distinctio doloremque.\nEius deserunt libero libero rerum quo possimus.\nMolestiae eos tempora reiciendis maiores consectetur.\nDicta autem quod facere.\nSed rerum exercitationem labore amet vel enim magni ut.\nEx et voluptates animi quis beatae accusantium.\nArchitecto modi nemo minima.\nDolores corporis voluptatem rerum voluptatem et libero quia.\nVoluptates quia inventore sit ullam molestiae atque error odio.\nQuia nulla molestias corporis quasi eum qui voluptatem.", new DateTime(2022, 10, 14, 9, 36, 51, 257, DateTimeKind.Local).AddTicks(9991), "Recusandae veritatis quisquam quia." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 1, "Eos nesciunt itaque dolorem quod.\nVoluptatum similique autem in.\nMinus perspiciatis eaque.\nAnimi nam excepturi dolor soluta quasi ut et repellat.\nQuaerat sed quas est reiciendis fugit vel et quibusdam consectetur.\nQuos voluptatem qui consectetur.\nRerum rem recusandae exercitationem.\nQuo dolor consequatur laudantium natus.\nMaxime et consectetur ut.\nEarum numquam atque quae ut a qui.", new DateTime(2022, 10, 14, 9, 36, 51, 258, DateTimeKind.Local).AddTicks(454), "Tempora nam non unde." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 5, "Odit ut est deserunt non molestiae molestiae optio.\nLaborum quam quam eos ratione esse sapiente harum.\nEst a est omnis aut laboriosam ratione sit nobis.\nRem distinctio ut.\nRecusandae est ex.\nTotam sequi suscipit omnis.\nFugiat labore id et fuga fugiat vel reiciendis dolores.\nLaboriosam eos necessitatibus aperiam iste dolore ut dignissimos ut maxime.\nModi ipsa autem voluptas corrupti.\nTemporibus sed dolores deleniti et nulla.", new DateTime(2022, 10, 14, 9, 36, 51, 258, DateTimeKind.Local).AddTicks(817), "Harum aut maxime nulla." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 2, "Ut accusamus aspernatur reiciendis nam eveniet tenetur.\nEst quibusdam delectus.\nQuo maiores sit.\nLaborum velit tempora id dolores quam.\nEst alias occaecati.\nNostrum id quaerat et placeat architecto sint repellat officiis aliquam.\nAutem deleniti quis dignissimos.\nDoloribus labore vel voluptas dignissimos dolorem optio neque.\nEnim sed iure.\nNulla quia aut ratione doloribus nam nemo et iste numquam.", new DateTime(2022, 10, 14, 9, 36, 51, 258, DateTimeKind.Local).AddTicks(1211), "Est enim et ad." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 1, "Dolorem placeat commodi eligendi optio.\nSed fuga facere.\nLaudantium ipsa aspernatur magni voluptatum sed.\nQuasi doloremque non enim tempora corrupti impedit.\nNostrum iusto voluptatem suscipit.\nBlanditiis soluta dolores quibusdam nostrum cupiditate quia eligendi incidunt vel.\nAliquid qui cupiditate velit ut sit nihil id molestias.\nSint fugit enim explicabo mollitia.\nExpedita natus ea mollitia excepturi.\nDolor consequatur dolor perspiciatis corporis.", new DateTime(2022, 10, 14, 9, 36, 51, 258, DateTimeKind.Local).AddTicks(1576), "Autem maiores qui velit." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 9, "Qui et fugiat delectus.\nAccusamus a perferendis veniam eum impedit ut.\nTempora cumque optio voluptatem occaecati dolores eum.\nAd inventore laborum sint.\nQuisquam doloremque qui repellendus qui molestiae.\nUt magni quia.\nExercitationem ratione est dignissimos qui tempora praesentium architecto totam.\nIpsam id ratione est.\nCumque aut repellat et eos eius ducimus sunt voluptatem.\nMolestiae et nobis veniam laudantium libero aspernatur non recusandae ut.", new DateTime(2022, 10, 14, 9, 36, 51, 258, DateTimeKind.Local).AddTicks(1941), "Tenetur commodi quo quo." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 4, "Ut ab sed voluptate molestiae odio explicabo.\nEst quasi ut ut enim.\nNulla illo ut sint sequi qui omnis.\nConsequatur unde eius architecto non quisquam rem aliquam et.\nIllum voluptatem soluta qui necessitatibus.\nQuas doloribus voluptate iure natus reprehenderit voluptas fugiat.\nReprehenderit consequuntur voluptatem voluptates.\nDeleniti voluptatem qui placeat quae expedita amet aliquid tempora.\nEum totam dignissimos sed ducimus.\nEos ducimus dolorem.", new DateTime(2022, 10, 14, 9, 36, 51, 258, DateTimeKind.Local).AddTicks(2336), "Ducimus eum harum quae." });

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Penny Koelpin");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Irvin Nader");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Salvador Pfannerstill");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Jeffery Corkery");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Shirley Jenkins");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Dorothy Anderson");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Virgil Legros");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Leona Bruen");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Jessie Schoen");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Nellie Zemlak");

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 9, "Qui incidunt atque.\nQui modi animi nostrum quia consequatur.\nDolor similique et quo quia dolores eos sed maiores velit.\nEt cumque sed accusamus.\nRerum tempore vel laudantium rem.\nOfficia qui facilis voluptatem et est sint ut id aliquid.\nQui quod optio ea.\nOptio natus quia.\nMinus est sunt animi dolor laboriosam quo.\nPorro et quibusdam perspiciatis occaecati quo reiciendis eius et.", new DateTime(2022, 10, 14, 0, 54, 7, 110, DateTimeKind.Local).AddTicks(4575), "Eligendi voluptatibus quod porro." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 9, "Eveniet molestiae aut vel quia hic debitis reiciendis illum.\nRecusandae non voluptatibus aut quae.\nQui reiciendis ab dolorem maiores omnis expedita.\nUt quisquam sit earum quo.\nTenetur magnam quis et cum.\nUt a ut sint.\nRerum reiciendis sed qui fuga repellat quia voluptatem voluptatem.\nAdipisci ut dolorum qui nisi est culpa voluptatum.\nVoluptas itaque eos rem iure nobis.\nDolor sit accusamus quidem fuga iusto magni maiores ut sunt.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(2137), "Non ipsum veniam dignissimos." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 5, "Occaecati quisquam possimus sit libero reiciendis suscipit ea voluptatem atque.\nVoluptatem ut et.\nVel ut nihil illum debitis voluptatem nobis.\nPossimus aut harum.\nAssumenda voluptatem accusamus velit minus temporibus.\nDolorum facere et.\nAliquam sed repellat totam ipsam qui aliquid reiciendis.\nPariatur et rerum.\nSunt ut aut assumenda fugiat porro repellat repudiandae eaque.\nError vitae qui veniam ex commodi rerum.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(3084), "Quo ad quisquam reiciendis." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 9, "Debitis soluta consequatur eos voluptate consequuntur unde.\nCumque soluta inventore et eum est dolore repellendus.\nEt facere numquam.\nIusto eum et vero repellat et velit ut.\nBlanditiis in quia quis modi.\nTotam at deserunt.\nQuos debitis eos ea reprehenderit expedita cupiditate tempore quidem.\nPorro iste deleniti.\nSint dignissimos ullam et.\nVelit molestias ut.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(3505), "Facere amet ut ducimus." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 7, "Laudantium nesciunt voluptatem sit eaque delectus est.\nSunt voluptatibus rem sed rem earum natus debitis mollitia.\nExplicabo necessitatibus consequatur dolor temporibus delectus pariatur dolor minima qui.\nRem dolor repudiandae voluptatem.\nNon deleniti est sed sint excepturi molestias aut accusamus ipsam.\nAut earum similique.\nDolor autem voluptas eum laborum dolor nobis consequatur aliquid.\nEos est culpa mollitia aspernatur.\nNatus ab quos minus vitae aut inventore eum qui.\nUt voluptates rem earum quae labore.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(3863), "Iure tempora deleniti quas." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 8, "Ut et non aut nihil sed expedita.\nMolestiae quas assumenda sint totam possimus ducimus quo cumque.\nMinus rerum et incidunt repudiandae est saepe voluptate.\nDolorum voluptatibus modi sequi quam.\nDoloremque molestias est sed ut soluta vero est omnis praesentium.\nQui a voluptatum quis temporibus officiis expedita voluptas rerum.\nQui nemo necessitatibus facere eius perferendis sint aperiam voluptas cumque.\nAliquid similique iusto dolore possimus.\nMinus repellat debitis eius ipsa est voluptatem harum.\nRecusandae repellat eum odit error iure voluptatum eaque corporis sed.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(4311), "Ea dignissimos soluta at." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 8, "Sint possimus velit autem reprehenderit eaque ipsa aperiam.\nMolestiae assumenda et eligendi.\nSed quod quia minima beatae sint quia id.\nSapiente officiis non magni.\nA sit reiciendis.\nItaque non quia perferendis id.\nUnde saepe tenetur quibusdam et rerum et velit ut.\nNam inventore voluptas voluptatum qui voluptatem atque.\nDolorum qui sint eos.\nRepellat architecto inventore rerum odio consequuntur neque error occaecati alias.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(4777), "Qui facere nam earum." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 3, "Et nisi laudantium dolor excepturi autem eveniet at quas.\nSint ipsa earum qui quis et nobis maiores.\nQuisquam consequatur eligendi dolor veniam amet illo ratione inventore quae.\nIn veritatis beatae enim sed odit qui soluta.\nDolorum quia sed dignissimos eligendi non.\nDolorum quia quo.\nQuae velit consequatur est inventore.\nNeque sit asperiores praesentium incidunt voluptas consequatur omnis ut.\nDelectus et minima sit totam consequatur officia suscipit perspiciatis.\nMagnam corrupti quasi et iusto voluptatem nisi.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(5156), "Minus sit sapiente voluptate." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 7, "Enim earum enim est itaque.\nSuscipit qui soluta nisi ex sequi.\nNulla provident necessitatibus ipsa est tempore qui blanditiis iste tempore.\nNon voluptatem quia.\nQuia et ratione et in autem.\nLabore adipisci ipsam est earum non quia similique ratione porro.\nDignissimos dolor vel quibusdam expedita deserunt eum dolore quibusdam facere.\nNeque omnis repudiandae sit quo.\nEt velit iste in laborum.\nNostrum eligendi est sapiente qui recusandae dolore doloribus non reprehenderit.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(5574), "Optio sed illo iure." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Body", "TimeStamp", "Title" },
                values: new object[] { "Iste quam sit in non ut.\nIste minus omnis.\nRecusandae tenetur rerum neque suscipit.\nExercitationem occaecati aut recusandae harum et ipsam omnis voluptas.\nEst maxime laboriosam sequi voluptatem rerum quia facilis.\nEt aperiam libero quia.\nDolorem tempora ut iste ipsam aperiam qui incidunt.\nMaxime minus neque tempora voluptatum molestiae voluptas sit.\nDignissimos incidunt voluptatem.\nQui est modi maiores placeat corporis accusantium sunt quibusdam.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(6018), "In doloremque nobis voluptas." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 7, "Possimus labore qui sequi ut et deserunt quam.\nQuisquam qui quisquam quis tempora aut tempora sunt in aliquid.\nCommodi suscipit voluptas quis minima sed qui rerum odit.\nRepellendus impedit occaecati vitae quaerat temporibus porro architecto quisquam maxime.\nAmet incidunt voluptatem sit qui expedita et temporibus in.\nEaque velit in.\nNihil voluptates dignissimos officiis laboriosam.\nFacilis enim accusantium recusandae voluptatem sed.\nUt eius excepturi sit soluta.\nAccusantium quia aut et enim optio unde.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(6418), "Velit odio voluptas ea." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 8, "Earum voluptas quo aut enim.\nEum ut nesciunt debitis.\nSit asperiores eum consequatur.\nSunt necessitatibus sunt ea aut omnis qui voluptatem voluptas quia.\nTemporibus possimus corrupti id.\nAmet est quaerat cupiditate.\nSuscipit labore illum ullam.\nAccusamus ullam ut id ad.\nDolor eum officia illum voluptas.\nCorrupti iure fuga occaecati eaque aspernatur.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(6831), "Nesciunt nihil at placeat." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 1, "Qui enim quia.\nOmnis ut et enim veritatis laudantium nobis voluptas quam.\nEveniet eos est.\nUt temporibus voluptate quibusdam labore accusamus ut et ullam eos.\nNihil fugiat velit doloremque accusamus deserunt consequatur consectetur suscipit.\nAliquid neque quos.\nVoluptatem nihil dolor aut non.\nNeque maiores in voluptas.\nFuga nisi aperiam magnam rerum ratione.\nSint deleniti ea harum corrupti vel unde sint saepe libero.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(7150), "Deserunt molestias libero enim." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Body", "TimeStamp", "Title" },
                values: new object[] { "Numquam dolorem sed sint consequatur itaque.\nPorro quaerat et unde dolore dolore ut earum.\nEt quam est perferendis ut reprehenderit.\nUt omnis esse nemo.\nQuo quo eius vero impedit officiis.\nDicta eum harum similique in nulla rerum autem illo.\nCorporis ut et qui rerum.\nMagni reiciendis ut quas qui hic voluptatem sapiente hic harum.\nConsequatur perspiciatis numquam est.\nQuis sequi vero natus nostrum pariatur architecto.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(7630), "Eos unde fuga repudiandae." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 2, "Voluptatem eum voluptas eum est.\nAut aut quis.\nDolores cum libero et rerum impedit harum eum quo in.\nSaepe assumenda officiis quia et minima et id quia.\nRepellendus dignissimos impedit et magnam quis dolor est consequuntur.\nMinus alias nesciunt quisquam aut dolorum ut consequuntur praesentium.\nAmet voluptas consequuntur corrupti aliquam laborum saepe quas.\nConsequatur reiciendis quasi.\nConsectetur aliquid ut sapiente.\nEligendi suscipit blanditiis inventore quo voluptas accusantium saepe laborum.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(8009), "Voluptas sit neque nihil." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 2, "Deleniti dolorum praesentium voluptatem eius.\nQuidem deleniti tempore expedita voluptatem fugiat nam.\nUt consequatur est distinctio esse iusto quia labore magni.\nEa laudantium ea alias quod et dicta.\nVelit autem quisquam similique necessitatibus repudiandae quod enim inventore.\nDolor ea reprehenderit recusandae commodi explicabo rerum dolor temporibus.\nEt nisi voluptatem labore corrupti nulla.\nPossimus amet harum id est sunt iste harum officiis vitae.\nVoluptatum id sint ratione autem enim.\nQui eius molestiae aspernatur ut ea.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(8407), "Odio aperiam quae omnis." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 10, "Atque vitae quae a voluptatibus dicta nihil sed.\nFugiat quo ullam quos.\nEt nemo illo.\nAtque delectus aut omnis omnis fuga.\nExpedita sint ad dolor sit eos nihil.\nIncidunt animi voluptatem et omnis itaque inventore hic voluptatem.\nEveniet eum consequuntur est aliquam.\nEt modi aliquam.\nSaepe possimus nihil voluptatem quam molestiae quia dolorem.\nLaboriosam voluptas ut esse.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(8822), "Ad impedit dolores vero." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 6, "Sint nihil perferendis qui quos.\nEt ea ab distinctio sequi consequuntur aut est est.\nVoluptatum saepe repellat aut aliquid et necessitatibus et vel ducimus.\nUt animi aliquid voluptas consectetur dolor rerum id tempora debitis.\nNon blanditiis dolor.\nAd molestias asperiores.\nQui commodi rerum rerum.\nOccaecati non eos molestiae ut provident non sint ipsa.\nEnim et optio qui delectus ut dolorem officiis unde consequatur.\nNobis ut fugiat sit nisi eum.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(9163), "Quaerat esse molestiae officiis." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 9, "Similique quia voluptatem sint voluptatem fugiat optio nam aut dolorem.\nEt eius in nobis doloremque et error.\nExplicabo quidem suscipit quo reprehenderit doloremque.\nNatus ratione ea ipsam voluptas quis earum.\nMagni dolores cumque molestiae qui eaque pariatur laboriosam suscipit.\nSit molestiae fugit voluptas cumque omnis id.\nArchitecto ut quia incidunt.\nOfficiis necessitatibus molestiae ad unde quaerat.\nVoluptas ratione sapiente autem ducimus amet voluptas odio quam.\nEt exercitationem repellat quia quis aut.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(9557), "Id porro error voluptas." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 5, "Ullam impedit occaecati eveniet.\nEum ut porro.\nCorporis vitae ut tempore officiis sapiente id voluptatem excepturi.\nUllam id dolorum doloribus accusantium incidunt.\nQuas repellendus rerum atque.\nHarum eius tempore.\nAliquam at unde dolor et eveniet cumque eligendi earum.\nPraesentium est dolores eos.\nVoluptatum itaque quia minima iusto soluta porro quos.\nNulla quia facere assumenda minima sed ducimus voluptatem.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(9953), "Autem ducimus fuga in." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 10, "Hic in aperiam non ab.\nEst sint consequatur est sed consequatur neque praesentium earum.\nDolorem ut ea aut.\nQuia ratione recusandae velit id.\nEos est rem et vero impedit id tempora debitis.\nPlaceat nam soluta saepe voluptas voluptatem.\nError enim eaque.\nAutem voluptas vero dolorem cupiditate rerum repellat est magnam aspernatur.\nEnim ipsa harum et provident numquam ut.\nIste incidunt et fugiat esse.", new DateTime(2022, 10, 14, 0, 54, 7, 114, DateTimeKind.Local).AddTicks(305), "Accusantium impedit rerum assumenda." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 9, "Consequatur eos cumque.\nOmnis rerum et voluptatem suscipit qui est qui fuga.\nUt aliquid quidem quaerat praesentium.\nNecessitatibus eius aut deleniti possimus enim non odio exercitationem.\nEveniet asperiores sint non minus autem laborum voluptatem officiis.\nSint hic perferendis deleniti hic dolor odio provident sit cupiditate.\nQui perspiciatis et.\nVoluptatem dolorem eius voluptatem.\nA quia ut corrupti molestiae laborum.\nEsse sunt vero id autem iure deleniti.", new DateTime(2022, 10, 14, 0, 54, 7, 114, DateTimeKind.Local).AddTicks(668), "Soluta doloribus consequatur at." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 9, "Officiis in aliquam assumenda aut dolorem ducimus at inventore culpa.\nReprehenderit labore quam voluptatem.\nVoluptatibus cupiditate omnis suscipit dolore voluptatem sapiente voluptas.\nNam laboriosam veritatis velit non rerum tempore est quae.\nIste sint velit nobis possimus neque soluta.\nDoloribus est ut dolores delectus.\nConsequuntur a soluta earum consectetur qui.\nOdio non maiores eos dolorem iure et nulla quidem.\nNihil consectetur voluptas laudantium dolorem dolor voluptas.\nQuia similique nam ut soluta odio provident autem id.", new DateTime(2022, 10, 14, 0, 54, 7, 114, DateTimeKind.Local).AddTicks(1045), "Earum quia dolores non." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Body", "TimeStamp", "Title" },
                values: new object[] { "Minus sed doloribus non unde.\nOmnis accusantium excepturi aliquid aut rerum earum consequuntur asperiores corporis.\nVoluptas ratione sit nesciunt.\nTotam dolore unde id.\nRepellendus qui deserunt autem aut quia.\nAut ut quo similique exercitationem eos qui perspiciatis voluptatem.\nSimilique quibusdam officia dolore laborum assumenda architecto.\nQui deleniti neque unde et quod.\nEarum deleniti asperiores dignissimos sint reiciendis corporis iusto.\nPerferendis facilis totam.", new DateTime(2022, 10, 14, 0, 54, 7, 114, DateTimeKind.Local).AddTicks(1450), "Magnam voluptatem minus dolores." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 7, "Pariatur soluta facere.\nSed quia vel.\nTenetur eius qui impedit error eligendi explicabo.\nAliquid vel ea aut incidunt facilis ut ea sint ut.\nCorporis laudantium officiis ullam at unde sint aut veritatis voluptates.\nMinima illum et in accusantium vitae impedit commodi qui tenetur.\nNihil adipisci ut eius excepturi.\nQuia velit reprehenderit et ut non excepturi illo beatae.\nOfficiis neque quae necessitatibus aperiam asperiores molestiae aut qui rem.\nEt sit et sequi dolor perferendis recusandae omnis soluta.", new DateTime(2022, 10, 14, 0, 54, 7, 114, DateTimeKind.Local).AddTicks(1817), "Unde veniam fuga et." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 4, "Occaecati nihil nemo est sed nisi rerum neque.\nSed voluptate veritatis suscipit impedit voluptas et harum ipsa.\nOfficia incidunt id nisi consectetur adipisci culpa exercitationem in occaecati.\nConsequuntur voluptas nostrum eum.\nConsequatur quibusdam aut ex corrupti tempore.\nQui tenetur autem.\nMollitia illo repudiandae mollitia alias asperiores placeat aut esse dolor.\nSed velit ut.\nUnde rerum mollitia.\nBeatae assumenda tenetur.", new DateTime(2022, 10, 14, 0, 54, 7, 114, DateTimeKind.Local).AddTicks(2241), "Quidem aperiam porro animi." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 3, "Repudiandae numquam sint reprehenderit vel dolore.\nEt atque molestiae ut dolores culpa minima delectus eligendi molestiae.\nNatus illum iusto quia autem modi debitis ullam.\nFacilis illum sequi mollitia.\nNemo enim aspernatur sed et.\nCorporis dolorem iste consequatur veritatis porro commodi earum.\nCorrupti maiores ut fugiat quia aspernatur.\nIpsa temporibus quo optio sint sint et laboriosam nihil.\nVoluptas necessitatibus dolorem nemo sit.\nEum labore autem qui quaerat et inventore expedita vero.", new DateTime(2022, 10, 14, 0, 54, 7, 114, DateTimeKind.Local).AddTicks(2589), "Omnis alias expedita nobis." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 10, "Enim dolore iusto tempora nemo.\nIpsum quia temporibus aut numquam.\nId reprehenderit voluptatum fugit consectetur nemo.\nQuo mollitia hic cumque.\nEsse qui sit quo culpa porro quis.\nQui consequatur inventore rerum reprehenderit beatae debitis in.\nVeritatis qui nostrum ipsa et quia ut eum.\nEst eum odio error est voluptatem perspiciatis dolorem vel.\nSit sit mollitia quasi qui sed et.\nSit fugiat quisquam aut molestiae qui illo provident.", new DateTime(2022, 10, 14, 0, 54, 7, 114, DateTimeKind.Local).AddTicks(2981), "Et eligendi distinctio minima." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 4, "Blanditiis possimus odit doloribus et culpa veniam id explicabo similique.\nCorporis eius voluptas totam excepturi.\nMolestias alias mollitia recusandae unde aspernatur et.\nEt molestias consectetur tenetur dolores aliquam rerum ipsum ut officiis.\nDelectus quod exercitationem distinctio dignissimos deserunt quod sequi nulla.\nId est et at.\nVeritatis ipsum consequatur voluptatibus voluptates expedita est doloremque fuga.\nExplicabo repellendus sapiente.\nFuga dolores tenetur blanditiis et.\nQui non laboriosam voluptatem laboriosam aut earum.", new DateTime(2022, 10, 14, 0, 54, 7, 114, DateTimeKind.Local).AddTicks(3360), "Velit similique ipsum voluptate." });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[] { 7, "Veniam adipisci rem.\nVeniam delectus dolor ea impedit.\nDeserunt aliquid consequatur omnis voluptas modi doloribus est.\nIusto corporis doloremque pariatur fugiat.\nRerum aut porro tenetur velit est quis ut.\nCum sed voluptatem omnis libero corrupti qui consectetur.\nUt maxime et.\nDoloremque aut iusto quo commodi excepturi est.\nAliquam nisi quidem cumque rerum eos laudantium ea molestias.\nNemo vel magni.", new DateTime(2022, 10, 14, 0, 54, 7, 114, DateTimeKind.Local).AddTicks(3758), "Eum perferendis repellendus quia." });
        }
    }
}
