using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class Authormodelupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogPosts_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { 1, null, "Penny Koelpin", null },
                    { 2, null, "Irvin Nader", null },
                    { 3, null, "Salvador Pfannerstill", null },
                    { 4, null, "Jeffery Corkery", null },
                    { 5, null, "Shirley Jenkins", null },
                    { 6, null, "Dorothy Anderson", null },
                    { 7, null, "Virgil Legros", null },
                    { 8, null, "Leona Bruen", null },
                    { 9, null, "Jessie Schoen", null },
                    { 10, null, "Nellie Zemlak", null }
                });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[,]
                {
                    { 10, 1, "Iste quam sit in non ut.\nIste minus omnis.\nRecusandae tenetur rerum neque suscipit.\nExercitationem occaecati aut recusandae harum et ipsam omnis voluptas.\nEst maxime laboriosam sequi voluptatem rerum quia facilis.\nEt aperiam libero quia.\nDolorem tempora ut iste ipsam aperiam qui incidunt.\nMaxime minus neque tempora voluptatum molestiae voluptas sit.\nDignissimos incidunt voluptatem.\nQui est modi maiores placeat corporis accusantium sunt quibusdam.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(6018), "In doloremque nobis voluptas." },
                    { 17, 10, "Atque vitae quae a voluptatibus dicta nihil sed.\nFugiat quo ullam quos.\nEt nemo illo.\nAtque delectus aut omnis omnis fuga.\nExpedita sint ad dolor sit eos nihil.\nIncidunt animi voluptatem et omnis itaque inventore hic voluptatem.\nEveniet eum consequuntur est aliquam.\nEt modi aliquam.\nSaepe possimus nihil voluptatem quam molestiae quia dolorem.\nLaboriosam voluptas ut esse.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(8822), "Ad impedit dolores vero." },
                    { 23, 9, "Officiis in aliquam assumenda aut dolorem ducimus at inventore culpa.\nReprehenderit labore quam voluptatem.\nVoluptatibus cupiditate omnis suscipit dolore voluptatem sapiente voluptas.\nNam laboriosam veritatis velit non rerum tempore est quae.\nIste sint velit nobis possimus neque soluta.\nDoloribus est ut dolores delectus.\nConsequuntur a soluta earum consectetur qui.\nOdio non maiores eos dolorem iure et nulla quidem.\nNihil consectetur voluptas laudantium dolorem dolor voluptas.\nQuia similique nam ut soluta odio provident autem id.", new DateTime(2022, 10, 14, 0, 54, 7, 114, DateTimeKind.Local).AddTicks(1045), "Earum quia dolores non." },
                    { 22, 9, "Consequatur eos cumque.\nOmnis rerum et voluptatem suscipit qui est qui fuga.\nUt aliquid quidem quaerat praesentium.\nNecessitatibus eius aut deleniti possimus enim non odio exercitationem.\nEveniet asperiores sint non minus autem laborum voluptatem officiis.\nSint hic perferendis deleniti hic dolor odio provident sit cupiditate.\nQui perspiciatis et.\nVoluptatem dolorem eius voluptatem.\nA quia ut corrupti molestiae laborum.\nEsse sunt vero id autem iure deleniti.", new DateTime(2022, 10, 14, 0, 54, 7, 114, DateTimeKind.Local).AddTicks(668), "Soluta doloribus consequatur at." },
                    { 19, 9, "Similique quia voluptatem sint voluptatem fugiat optio nam aut dolorem.\nEt eius in nobis doloremque et error.\nExplicabo quidem suscipit quo reprehenderit doloremque.\nNatus ratione ea ipsam voluptas quis earum.\nMagni dolores cumque molestiae qui eaque pariatur laboriosam suscipit.\nSit molestiae fugit voluptas cumque omnis id.\nArchitecto ut quia incidunt.\nOfficiis necessitatibus molestiae ad unde quaerat.\nVoluptas ratione sapiente autem ducimus amet voluptas odio quam.\nEt exercitationem repellat quia quis aut.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(9557), "Id porro error voluptas." },
                    { 4, 9, "Debitis soluta consequatur eos voluptate consequuntur unde.\nCumque soluta inventore et eum est dolore repellendus.\nEt facere numquam.\nIusto eum et vero repellat et velit ut.\nBlanditiis in quia quis modi.\nTotam at deserunt.\nQuos debitis eos ea reprehenderit expedita cupiditate tempore quidem.\nPorro iste deleniti.\nSint dignissimos ullam et.\nVelit molestias ut.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(3505), "Facere amet ut ducimus." },
                    { 2, 9, "Eveniet molestiae aut vel quia hic debitis reiciendis illum.\nRecusandae non voluptatibus aut quae.\nQui reiciendis ab dolorem maiores omnis expedita.\nUt quisquam sit earum quo.\nTenetur magnam quis et cum.\nUt a ut sint.\nRerum reiciendis sed qui fuga repellat quia voluptatem voluptatem.\nAdipisci ut dolorum qui nisi est culpa voluptatum.\nVoluptas itaque eos rem iure nobis.\nDolor sit accusamus quidem fuga iusto magni maiores ut sunt.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(2137), "Non ipsum veniam dignissimos." },
                    { 1, 9, "Qui incidunt atque.\nQui modi animi nostrum quia consequatur.\nDolor similique et quo quia dolores eos sed maiores velit.\nEt cumque sed accusamus.\nRerum tempore vel laudantium rem.\nOfficia qui facilis voluptatem et est sint ut id aliquid.\nQui quod optio ea.\nOptio natus quia.\nMinus est sunt animi dolor laboriosam quo.\nPorro et quibusdam perspiciatis occaecati quo reiciendis eius et.", new DateTime(2022, 10, 14, 0, 54, 7, 110, DateTimeKind.Local).AddTicks(4575), "Eligendi voluptatibus quod porro." },
                    { 12, 8, "Earum voluptas quo aut enim.\nEum ut nesciunt debitis.\nSit asperiores eum consequatur.\nSunt necessitatibus sunt ea aut omnis qui voluptatem voluptas quia.\nTemporibus possimus corrupti id.\nAmet est quaerat cupiditate.\nSuscipit labore illum ullam.\nAccusamus ullam ut id ad.\nDolor eum officia illum voluptas.\nCorrupti iure fuga occaecati eaque aspernatur.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(6831), "Nesciunt nihil at placeat." },
                    { 7, 8, "Sint possimus velit autem reprehenderit eaque ipsa aperiam.\nMolestiae assumenda et eligendi.\nSed quod quia minima beatae sint quia id.\nSapiente officiis non magni.\nA sit reiciendis.\nItaque non quia perferendis id.\nUnde saepe tenetur quibusdam et rerum et velit ut.\nNam inventore voluptas voluptatum qui voluptatem atque.\nDolorum qui sint eos.\nRepellat architecto inventore rerum odio consequuntur neque error occaecati alias.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(4777), "Qui facere nam earum." },
                    { 6, 8, "Ut et non aut nihil sed expedita.\nMolestiae quas assumenda sint totam possimus ducimus quo cumque.\nMinus rerum et incidunt repudiandae est saepe voluptate.\nDolorum voluptatibus modi sequi quam.\nDoloremque molestias est sed ut soluta vero est omnis praesentium.\nQui a voluptatum quis temporibus officiis expedita voluptas rerum.\nQui nemo necessitatibus facere eius perferendis sint aperiam voluptas cumque.\nAliquid similique iusto dolore possimus.\nMinus repellat debitis eius ipsa est voluptatem harum.\nRecusandae repellat eum odit error iure voluptatum eaque corporis sed.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(4311), "Ea dignissimos soluta at." },
                    { 30, 7, "Veniam adipisci rem.\nVeniam delectus dolor ea impedit.\nDeserunt aliquid consequatur omnis voluptas modi doloribus est.\nIusto corporis doloremque pariatur fugiat.\nRerum aut porro tenetur velit est quis ut.\nCum sed voluptatem omnis libero corrupti qui consectetur.\nUt maxime et.\nDoloremque aut iusto quo commodi excepturi est.\nAliquam nisi quidem cumque rerum eos laudantium ea molestias.\nNemo vel magni.", new DateTime(2022, 10, 14, 0, 54, 7, 114, DateTimeKind.Local).AddTicks(3758), "Eum perferendis repellendus quia." },
                    { 25, 7, "Pariatur soluta facere.\nSed quia vel.\nTenetur eius qui impedit error eligendi explicabo.\nAliquid vel ea aut incidunt facilis ut ea sint ut.\nCorporis laudantium officiis ullam at unde sint aut veritatis voluptates.\nMinima illum et in accusantium vitae impedit commodi qui tenetur.\nNihil adipisci ut eius excepturi.\nQuia velit reprehenderit et ut non excepturi illo beatae.\nOfficiis neque quae necessitatibus aperiam asperiores molestiae aut qui rem.\nEt sit et sequi dolor perferendis recusandae omnis soluta.", new DateTime(2022, 10, 14, 0, 54, 7, 114, DateTimeKind.Local).AddTicks(1817), "Unde veniam fuga et." },
                    { 11, 7, "Possimus labore qui sequi ut et deserunt quam.\nQuisquam qui quisquam quis tempora aut tempora sunt in aliquid.\nCommodi suscipit voluptas quis minima sed qui rerum odit.\nRepellendus impedit occaecati vitae quaerat temporibus porro architecto quisquam maxime.\nAmet incidunt voluptatem sit qui expedita et temporibus in.\nEaque velit in.\nNihil voluptates dignissimos officiis laboriosam.\nFacilis enim accusantium recusandae voluptatem sed.\nUt eius excepturi sit soluta.\nAccusantium quia aut et enim optio unde.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(6418), "Velit odio voluptas ea." },
                    { 9, 7, "Enim earum enim est itaque.\nSuscipit qui soluta nisi ex sequi.\nNulla provident necessitatibus ipsa est tempore qui blanditiis iste tempore.\nNon voluptatem quia.\nQuia et ratione et in autem.\nLabore adipisci ipsam est earum non quia similique ratione porro.\nDignissimos dolor vel quibusdam expedita deserunt eum dolore quibusdam facere.\nNeque omnis repudiandae sit quo.\nEt velit iste in laborum.\nNostrum eligendi est sapiente qui recusandae dolore doloribus non reprehenderit.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(5574), "Optio sed illo iure." },
                    { 5, 7, "Laudantium nesciunt voluptatem sit eaque delectus est.\nSunt voluptatibus rem sed rem earum natus debitis mollitia.\nExplicabo necessitatibus consequatur dolor temporibus delectus pariatur dolor minima qui.\nRem dolor repudiandae voluptatem.\nNon deleniti est sed sint excepturi molestias aut accusamus ipsam.\nAut earum similique.\nDolor autem voluptas eum laborum dolor nobis consequatur aliquid.\nEos est culpa mollitia aspernatur.\nNatus ab quos minus vitae aut inventore eum qui.\nUt voluptates rem earum quae labore.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(3863), "Iure tempora deleniti quas." },
                    { 18, 6, "Sint nihil perferendis qui quos.\nEt ea ab distinctio sequi consequuntur aut est est.\nVoluptatum saepe repellat aut aliquid et necessitatibus et vel ducimus.\nUt animi aliquid voluptas consectetur dolor rerum id tempora debitis.\nNon blanditiis dolor.\nAd molestias asperiores.\nQui commodi rerum rerum.\nOccaecati non eos molestiae ut provident non sint ipsa.\nEnim et optio qui delectus ut dolorem officiis unde consequatur.\nNobis ut fugiat sit nisi eum.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(9163), "Quaerat esse molestiae officiis." },
                    { 20, 5, "Ullam impedit occaecati eveniet.\nEum ut porro.\nCorporis vitae ut tempore officiis sapiente id voluptatem excepturi.\nUllam id dolorum doloribus accusantium incidunt.\nQuas repellendus rerum atque.\nHarum eius tempore.\nAliquam at unde dolor et eveniet cumque eligendi earum.\nPraesentium est dolores eos.\nVoluptatum itaque quia minima iusto soluta porro quos.\nNulla quia facere assumenda minima sed ducimus voluptatem.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(9953), "Autem ducimus fuga in." },
                    { 3, 5, "Occaecati quisquam possimus sit libero reiciendis suscipit ea voluptatem atque.\nVoluptatem ut et.\nVel ut nihil illum debitis voluptatem nobis.\nPossimus aut harum.\nAssumenda voluptatem accusamus velit minus temporibus.\nDolorum facere et.\nAliquam sed repellat totam ipsam qui aliquid reiciendis.\nPariatur et rerum.\nSunt ut aut assumenda fugiat porro repellat repudiandae eaque.\nError vitae qui veniam ex commodi rerum.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(3084), "Quo ad quisquam reiciendis." },
                    { 29, 4, "Blanditiis possimus odit doloribus et culpa veniam id explicabo similique.\nCorporis eius voluptas totam excepturi.\nMolestias alias mollitia recusandae unde aspernatur et.\nEt molestias consectetur tenetur dolores aliquam rerum ipsum ut officiis.\nDelectus quod exercitationem distinctio dignissimos deserunt quod sequi nulla.\nId est et at.\nVeritatis ipsum consequatur voluptatibus voluptates expedita est doloremque fuga.\nExplicabo repellendus sapiente.\nFuga dolores tenetur blanditiis et.\nQui non laboriosam voluptatem laboriosam aut earum.", new DateTime(2022, 10, 14, 0, 54, 7, 114, DateTimeKind.Local).AddTicks(3360), "Velit similique ipsum voluptate." },
                    { 26, 4, "Occaecati nihil nemo est sed nisi rerum neque.\nSed voluptate veritatis suscipit impedit voluptas et harum ipsa.\nOfficia incidunt id nisi consectetur adipisci culpa exercitationem in occaecati.\nConsequuntur voluptas nostrum eum.\nConsequatur quibusdam aut ex corrupti tempore.\nQui tenetur autem.\nMollitia illo repudiandae mollitia alias asperiores placeat aut esse dolor.\nSed velit ut.\nUnde rerum mollitia.\nBeatae assumenda tenetur.", new DateTime(2022, 10, 14, 0, 54, 7, 114, DateTimeKind.Local).AddTicks(2241), "Quidem aperiam porro animi." },
                    { 27, 3, "Repudiandae numquam sint reprehenderit vel dolore.\nEt atque molestiae ut dolores culpa minima delectus eligendi molestiae.\nNatus illum iusto quia autem modi debitis ullam.\nFacilis illum sequi mollitia.\nNemo enim aspernatur sed et.\nCorporis dolorem iste consequatur veritatis porro commodi earum.\nCorrupti maiores ut fugiat quia aspernatur.\nIpsa temporibus quo optio sint sint et laboriosam nihil.\nVoluptas necessitatibus dolorem nemo sit.\nEum labore autem qui quaerat et inventore expedita vero.", new DateTime(2022, 10, 14, 0, 54, 7, 114, DateTimeKind.Local).AddTicks(2589), "Omnis alias expedita nobis." },
                    { 14, 3, "Numquam dolorem sed sint consequatur itaque.\nPorro quaerat et unde dolore dolore ut earum.\nEt quam est perferendis ut reprehenderit.\nUt omnis esse nemo.\nQuo quo eius vero impedit officiis.\nDicta eum harum similique in nulla rerum autem illo.\nCorporis ut et qui rerum.\nMagni reiciendis ut quas qui hic voluptatem sapiente hic harum.\nConsequatur perspiciatis numquam est.\nQuis sequi vero natus nostrum pariatur architecto.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(7630), "Eos unde fuga repudiandae." },
                    { 8, 3, "Et nisi laudantium dolor excepturi autem eveniet at quas.\nSint ipsa earum qui quis et nobis maiores.\nQuisquam consequatur eligendi dolor veniam amet illo ratione inventore quae.\nIn veritatis beatae enim sed odit qui soluta.\nDolorum quia sed dignissimos eligendi non.\nDolorum quia quo.\nQuae velit consequatur est inventore.\nNeque sit asperiores praesentium incidunt voluptas consequatur omnis ut.\nDelectus et minima sit totam consequatur officia suscipit perspiciatis.\nMagnam corrupti quasi et iusto voluptatem nisi.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(5156), "Minus sit sapiente voluptate." },
                    { 16, 2, "Deleniti dolorum praesentium voluptatem eius.\nQuidem deleniti tempore expedita voluptatem fugiat nam.\nUt consequatur est distinctio esse iusto quia labore magni.\nEa laudantium ea alias quod et dicta.\nVelit autem quisquam similique necessitatibus repudiandae quod enim inventore.\nDolor ea reprehenderit recusandae commodi explicabo rerum dolor temporibus.\nEt nisi voluptatem labore corrupti nulla.\nPossimus amet harum id est sunt iste harum officiis vitae.\nVoluptatum id sint ratione autem enim.\nQui eius molestiae aspernatur ut ea.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(8407), "Odio aperiam quae omnis." },
                    { 15, 2, "Voluptatem eum voluptas eum est.\nAut aut quis.\nDolores cum libero et rerum impedit harum eum quo in.\nSaepe assumenda officiis quia et minima et id quia.\nRepellendus dignissimos impedit et magnam quis dolor est consequuntur.\nMinus alias nesciunt quisquam aut dolorum ut consequuntur praesentium.\nAmet voluptas consequuntur corrupti aliquam laborum saepe quas.\nConsequatur reiciendis quasi.\nConsectetur aliquid ut sapiente.\nEligendi suscipit blanditiis inventore quo voluptas accusantium saepe laborum.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(8009), "Voluptas sit neque nihil." },
                    { 24, 1, "Minus sed doloribus non unde.\nOmnis accusantium excepturi aliquid aut rerum earum consequuntur asperiores corporis.\nVoluptas ratione sit nesciunt.\nTotam dolore unde id.\nRepellendus qui deserunt autem aut quia.\nAut ut quo similique exercitationem eos qui perspiciatis voluptatem.\nSimilique quibusdam officia dolore laborum assumenda architecto.\nQui deleniti neque unde et quod.\nEarum deleniti asperiores dignissimos sint reiciendis corporis iusto.\nPerferendis facilis totam.", new DateTime(2022, 10, 14, 0, 54, 7, 114, DateTimeKind.Local).AddTicks(1450), "Magnam voluptatem minus dolores." },
                    { 13, 1, "Qui enim quia.\nOmnis ut et enim veritatis laudantium nobis voluptas quam.\nEveniet eos est.\nUt temporibus voluptate quibusdam labore accusamus ut et ullam eos.\nNihil fugiat velit doloremque accusamus deserunt consequatur consectetur suscipit.\nAliquid neque quos.\nVoluptatem nihil dolor aut non.\nNeque maiores in voluptas.\nFuga nisi aperiam magnam rerum ratione.\nSint deleniti ea harum corrupti vel unde sint saepe libero.", new DateTime(2022, 10, 14, 0, 54, 7, 113, DateTimeKind.Local).AddTicks(7150), "Deserunt molestias libero enim." },
                    { 21, 10, "Hic in aperiam non ab.\nEst sint consequatur est sed consequatur neque praesentium earum.\nDolorem ut ea aut.\nQuia ratione recusandae velit id.\nEos est rem et vero impedit id tempora debitis.\nPlaceat nam soluta saepe voluptas voluptatem.\nError enim eaque.\nAutem voluptas vero dolorem cupiditate rerum repellat est magnam aspernatur.\nEnim ipsa harum et provident numquam ut.\nIste incidunt et fugiat esse.", new DateTime(2022, 10, 14, 0, 54, 7, 114, DateTimeKind.Local).AddTicks(305), "Accusantium impedit rerum assumenda." },
                    { 28, 10, "Enim dolore iusto tempora nemo.\nIpsum quia temporibus aut numquam.\nId reprehenderit voluptatum fugit consectetur nemo.\nQuo mollitia hic cumque.\nEsse qui sit quo culpa porro quis.\nQui consequatur inventore rerum reprehenderit beatae debitis in.\nVeritatis qui nostrum ipsa et quia ut eum.\nEst eum odio error est voluptatem perspiciatis dolorem vel.\nSit sit mollitia quasi qui sed et.\nSit fugiat quisquam aut molestiae qui illo provident.", new DateTime(2022, 10, 14, 0, 54, 7, 114, DateTimeKind.Local).AddTicks(2981), "Et eligendi distinctio minima." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_AuthorId",
                table: "BlogPosts",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
