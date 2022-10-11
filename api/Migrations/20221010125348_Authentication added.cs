using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class Authenticationadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
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
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sonia Cole" },
                    { 2, "Shelia Ryan" },
                    { 3, "Thelma Casper" },
                    { 4, "Pat Spinka" },
                    { 5, "Jack Gulgowski" },
                    { 6, "Ryan Schaden" },
                    { 7, "April Jast" },
                    { 8, "April Moore" },
                    { 9, "Bonnie Thompson" },
                    { 10, "Kelvin Ruecker" }
                });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[,]
                {
                    { 9, 1, "Eaque qui culpa repellendus incidunt voluptatem earum distinctio harum.\nIncidunt sint a odit sit et.\nQuia libero porro ad vero ut voluptatem sit.\nArchitecto quia aspernatur deleniti.\nConsequatur corporis accusantium.\nDolores dignissimos et perferendis soluta neque.\nDolor porro et.\nAspernatur omnis quibusdam consectetur minima doloribus sapiente laborum non sit.\nIste voluptas inventore architecto illum.\nSequi nostrum nihil numquam non quidem nobis.", new DateTime(2022, 10, 10, 13, 53, 48, 223, DateTimeKind.Local).AddTicks(8689), "Voluptates neque harum sit." },
                    { 16, 10, "Aperiam et enim nisi minus molestiae iusto omnis qui.\nAd et voluptate est.\nTemporibus sed architecto neque quae porro quibusdam iste minima.\nQuam inventore sapiente illum natus ea et eum voluptates voluptatem.\nInventore perspiciatis dolor autem reiciendis unde non sequi molestiae consectetur.\nDoloribus est dolores aperiam minus.\nAssumenda sed ut consequatur asperiores ea.\nQuis voluptatum minus quaerat est.\nAtque dolores consequatur ut minus.\nNostrum quis quasi ipsum officia in ex.", new DateTime(2022, 10, 10, 13, 53, 48, 224, DateTimeKind.Local).AddTicks(1015), "Sequi aut deserunt vel." },
                    { 15, 9, "Facilis vitae eius laboriosam.\nNisi qui natus quisquam ut quia.\nPorro sit ab nesciunt qui reiciendis ad est eos.\nPlaceat suscipit qui neque recusandae exercitationem provident iure assumenda.\nSequi eaque facilis.\nConsequatur officia eum.\nVel dolorem necessitatibus deleniti asperiores sunt.\nDolores maxime quo quia dolores velit maxime aliquid.\nSit rerum sint modi velit aspernatur doloremque suscipit velit.\nTempore cum sed.", new DateTime(2022, 10, 10, 13, 53, 48, 224, DateTimeKind.Local).AddTicks(679), "Id voluptatum rem qui." },
                    { 14, 9, "Assumenda voluptas optio.\nIpsam distinctio est quis nihil.\nAb magnam molestiae modi.\nAliquam praesentium et minima tempore beatae alias.\nCorrupti delectus impedit numquam expedita quis ut voluptatum aliquam eum.\nPlaceat beatae vero dolore quam.\nQui id et laborum.\nEa doloribus dolore.\nUnde aliquam nostrum quia modi non assumenda.\nNon iure est ducimus fugit repudiandae qui soluta quibusdam.", new DateTime(2022, 10, 10, 13, 53, 48, 224, DateTimeKind.Local).AddTicks(362), "Quo ea corrupti eveniet." },
                    { 13, 9, "Asperiores consequatur architecto iusto sit suscipit.\nIn cum quia placeat corrupti ratione omnis itaque amet dolorem.\nAtque laborum omnis neque.\nQuibusdam odit consequatur quos sit aut itaque nisi.\nLaudantium odit doloribus autem provident magnam quod.\nConsequatur veritatis aut eos eveniet aut.\nQui harum dolorum.\nNobis maxime quia nobis fugiat quod minima.\nOccaecati nulla iste animi id.\nTempora accusantium eaque assumenda qui expedita repudiandae totam dicta.", new DateTime(2022, 10, 10, 13, 53, 48, 224, DateTimeKind.Local).AddTicks(19), "Temporibus saepe incidunt repellendus." },
                    { 7, 9, "Nemo et est qui vel eum laborum exercitationem et non.\nEa earum et magni et rerum et optio.\nQui sint qui magni sunt eos.\nRatione at quis ut eum ut quas sed molestias vitae.\nEt similique enim itaque sunt dolorum.\nNihil similique fugit totam doloremque eius omnis.\nProvident error reprehenderit molestiae rerum similique.\nRecusandae totam odio sit.\nQuis quia iusto delectus dolorum porro ut alias.\nQuasi blanditiis ut odit.", new DateTime(2022, 10, 10, 13, 53, 48, 223, DateTimeKind.Local).AddTicks(7992), "Vero dolorem aut voluptates." },
                    { 28, 8, "Sed sapiente minus impedit animi dolores.\nLaborum sed asperiores qui qui voluptatem amet iusto consequuntur quo.\nIllo tenetur voluptas et.\nNesciunt quas eaque ut voluptates odio impedit quas non quis.\nQui quia repudiandae dicta fugit id facere molestias eveniet.\nDolorum dicta aut beatae ut id dolorem nemo dolorem.\nQuidem exercitationem perferendis sunt quia natus.\nAlias ipsum quos quos.\nOdio corrupti id voluptatem numquam facere aut ipsam velit aliquam.\nAut ut esse.", new DateTime(2022, 10, 10, 13, 53, 48, 224, DateTimeKind.Local).AddTicks(5270), "Alias sed debitis velit." },
                    { 27, 8, "Aut quibusdam perferendis est tempore error sed.\nNecessitatibus nobis laboriosam sint aut qui totam eos.\nReiciendis qui porro voluptatem consectetur voluptates aut et architecto dolore.\nAut ad molestias et deleniti neque accusantium nostrum quia.\nSit accusantium alias doloremque cupiditate temporibus voluptates aperiam.\nEt odio voluptas sunt omnis et earum quis.\nRerum consequatur dolor animi voluptatem ea sed.\nQuia impedit eaque consequatur cumque dolor et.\nEst autem porro incidunt.\nQuia aspernatur fugiat dignissimos vel commodi ut nihil.", new DateTime(2022, 10, 10, 13, 53, 48, 224, DateTimeKind.Local).AddTicks(4881), "Qui possimus qui distinctio." },
                    { 22, 8, "Et et reprehenderit.\nEnim quasi reprehenderit dolorem id et voluptatibus necessitatibus quia.\nSed totam tenetur incidunt quia impedit voluptatem.\nEius earum et nemo.\nEt et omnis et.\nLaudantium consectetur iure dolorem iste mollitia quisquam.\nAb maiores est dolorem quia autem distinctio quaerat.\nSit quidem sapiente magni illo.\nFuga accusantium qui fugit consequatur vero sapiente ut amet.\nMolestiae nihil perferendis non eaque repudiandae ex excepturi sint expedita.", new DateTime(2022, 10, 10, 13, 53, 48, 224, DateTimeKind.Local).AddTicks(3143), "Officia adipisci suscipit omnis." },
                    { 18, 8, "Consequatur hic quo et assumenda vero eum.\nNam debitis deleniti tenetur vero pariatur dolor ut sapiente.\nEum ullam mollitia nihil maxime eos quia.\nFugit earum sed ab est.\nDolor aliquam molestiae et deserunt.\nUt quaerat iusto doloribus omnis qui dolor debitis sed.\nNobis molestias inventore aut veniam fugiat.\nCulpa quia optio velit odio maxime rerum ut laborum enim.\nQuia animi quam sequi.\nAspernatur reiciendis similique et id officiis ut sapiente.", new DateTime(2022, 10, 10, 13, 53, 48, 224, DateTimeKind.Local).AddTicks(1723), "Sit dolorum fugit dolores." },
                    { 17, 8, "Libero voluptatum laborum autem vitae perspiciatis et.\nTotam nihil quas vel.\nVel iste nihil voluptas dolorum dolorem ea blanditiis dignissimos veritatis.\nRerum est delectus quidem distinctio nesciunt corporis labore.\nMinus odit saepe.\nNihil quis ex nam odio dolorem rerum error ex.\nSit et ipsa reprehenderit ducimus velit minima quasi.\nVelit repudiandae nulla iusto.\nEt deleniti nemo sed voluptatem omnis numquam.\nDistinctio fugiat veritatis suscipit totam.", new DateTime(2022, 10, 10, 13, 53, 48, 224, DateTimeKind.Local).AddTicks(1375), "Sequi et ut soluta." },
                    { 20, 7, "Temporibus unde ut eaque culpa eum.\nDolore rem iusto ipsum qui veniam dicta et iure.\nEst at magni qui quaerat.\nMolestiae ipsa minus.\nRerum voluptatem voluptas commodi.\nEum et alias at voluptatem excepturi maxime reiciendis ut ut.\nIllo et sed voluptatem neque aut enim et dolorem.\nFacilis ipsam non totam reiciendis asperiores nulla magnam modi.\nQui quasi magnam sed vel dicta et commodi repellendus et.\nNeque voluptates totam accusantium exercitationem molestias impedit ut harum ab.", new DateTime(2022, 10, 10, 13, 53, 48, 224, DateTimeKind.Local).AddTicks(2443), "Ut omnis rerum est." },
                    { 8, 7, "Et dolor ut nihil itaque ratione qui odio quo.\nHarum voluptas et et hic tempora culpa magni ratione.\nIpsam maiores possimus veniam praesentium odit ipsa illum accusantium.\nTempore voluptatem temporibus et voluptatem necessitatibus ipsam quam.\nIllum eaque ad in dolor et.\nA aut nesciunt reprehenderit.\nOdio harum fugiat molestias vitae.\nEst dolore eum.\nVoluptas esse dolores.\nDeleniti illo aut reiciendis.", new DateTime(2022, 10, 10, 13, 53, 48, 223, DateTimeKind.Local).AddTicks(8357), "Et similique dolor cum." },
                    { 6, 7, "Inventore quaerat autem rerum quia.\nMinus ad numquam rerum voluptate ut.\nRepudiandae a saepe corrupti quae laboriosam sed.\nDeserunt esse non sunt.\nAccusantium suscipit ex voluptatibus omnis in neque molestias voluptate.\nExercitationem expedita amet excepturi explicabo.\nEt odit iste ipsam quidem.\nMolestias maxime nobis ratione consequatur quos ratione laudantium.\nNeque vero perspiciatis dignissimos qui et ut amet eum.\nEt molestias laborum animi.", new DateTime(2022, 10, 10, 13, 53, 48, 223, DateTimeKind.Local).AddTicks(7585), "Quia consectetur impedit optio." },
                    { 3, 7, "Est sed aut reprehenderit numquam eos dolores officia dolore rerum.\nQuae natus a ullam enim et aliquid.\nEsse sint necessitatibus aliquam.\nTotam quis totam nemo architecto labore.\nDebitis earum molestiae beatae impedit.\nAperiam eum voluptatibus repudiandae ut.\nEnim id excepturi.\nUt rerum ea sapiente recusandae numquam distinctio sit rerum.\nSed et molestiae reprehenderit consectetur excepturi aut id id aut.\nDebitis officia et deserunt.", new DateTime(2022, 10, 10, 13, 53, 48, 223, DateTimeKind.Local).AddTicks(6421), "Officia quis in beatae." },
                    { 2, 7, "Incidunt consectetur est ut aut est beatae.\nSaepe aut totam ipsam cumque non cumque at officia et.\nMaiores deleniti ea repellendus esse autem aut fuga ex.\nIn ut rerum.\nMolestiae voluptates laboriosam alias cum nihil esse itaque.\nDoloribus exercitationem architecto in saepe et et consequatur.\nHarum illo in accusantium.\nEa incidunt rem eligendi accusantium quisquam est quos impedit.\nEt ad voluptatem commodi pariatur repudiandae commodi nihil quae.\nVelit corrupti nisi eius eius iste iusto nemo amet.", new DateTime(2022, 10, 10, 13, 53, 48, 223, DateTimeKind.Local).AddTicks(5697), "Et cumque saepe eum." },
                    { 25, 6, "Harum dicta et voluptatem eveniet perferendis et eius.\nQuod quia hic numquam dolores.\nOdio ut sint dicta est suscipit facere quis.\nNobis neque tempore est.\nAmet odit autem doloremque.\nIpsum occaecati minima consequatur laudantium vitae eum.\nOmnis quae voluptatibus consectetur optio ipsam sunt.\nIllo architecto tenetur.\nAutem aut et qui culpa.\nNisi ut aperiam et quidem et et et.", new DateTime(2022, 10, 10, 13, 53, 48, 224, DateTimeKind.Local).AddTicks(4217), "Accusantium doloribus ipsa dolores." },
                    { 24, 6, "Rerum occaecati sit asperiores assumenda.\nEst sit tempora odio possimus ut fuga placeat aliquam.\nReprehenderit voluptatibus ullam fuga ut modi.\nRerum consectetur neque rem sunt.\nDolores asperiores et laudantium quo deserunt fugit sint earum magnam.\nAnimi minima sit eius ipsum iste architecto ea dolorem.\nQuia vel cumque.\nExplicabo esse neque ullam.\nEst nisi harum ea explicabo dignissimos quo aut temporibus.\nQui repudiandae qui minus.", new DateTime(2022, 10, 10, 13, 53, 48, 224, DateTimeKind.Local).AddTicks(3881), "Excepturi ea alias quo." },
                    { 12, 6, "Asperiores rerum temporibus ratione voluptas et.\nTempore animi rerum quia.\nExplicabo debitis quidem laboriosam sint magni.\nVoluptatem repellendus ex ea dignissimos.\nId porro placeat aut autem at.\nNumquam nemo esse rerum ut.\nOptio repellat maiores ut dolor qui.\nFacere dolore sunt maiores.\nId nobis quasi minus.\nQuidem deleniti nisi est officia amet quos sunt.", new DateTime(2022, 10, 10, 13, 53, 48, 223, DateTimeKind.Local).AddTicks(9717), "Quia illum qui illo." },
                    { 4, 6, "Officiis a esse quia nihil quo minima voluptate nam veniam.\nAdipisci omnis vel fugit et officia.\nIure dicta nam et velit quod totam exercitationem.\nConsequatur velit aut nesciunt alias sunt.\nNam delectus excepturi enim assumenda et minus adipisci architecto illum.\nNobis dolorem odit deleniti et et dolor harum.\nVoluptatem aut perspiciatis tempore et consequuntur enim voluptates.\nExpedita quia voluptate aut et voluptatem voluptatem reprehenderit ipsam a.\nAliquid totam temporibus deserunt perferendis repellendus rem.\nNecessitatibus autem reprehenderit vel quis.", new DateTime(2022, 10, 10, 13, 53, 48, 223, DateTimeKind.Local).AddTicks(6796), "Quia quas sit autem." },
                    { 10, 5, "Beatae unde aut illo.\nUllam voluptas voluptates.\nDolores nulla eligendi et.\nDolor rerum eos tenetur est.\nPerspiciatis et nihil dolores placeat.\nEos fugit assumenda iste.\nReiciendis inventore ea aut assumenda qui impedit voluptatibus est.\nEt tenetur nesciunt culpa occaecati molestiae.\nMolestias ut qui sed vel.\nEt ducimus quia est.", new DateTime(2022, 10, 10, 13, 53, 48, 223, DateTimeKind.Local).AddTicks(9040), "Est nesciunt maiores iste." },
                    { 19, 4, "Quas sit hic quaerat pariatur quam eveniet ducimus aut sint.\nPossimus earum consequuntur repellat nihil id veritatis.\nEt a consequuntur quo ut reprehenderit impedit.\nId vitae enim fugit et sed et voluptas dolorem.\nLaboriosam sunt minus maxime.\nDebitis illo enim pariatur recusandae eius sapiente fuga.\nSimilique est dolorem eaque vel corporis reiciendis.\nEos natus nesciunt consequatur temporibus in molestiae omnis quia.\nFugiat deleniti voluptatem corrupti et.\nNemo magnam distinctio.", new DateTime(2022, 10, 10, 13, 53, 48, 224, DateTimeKind.Local).AddTicks(2091), "Consequuntur et quaerat doloremque." },
                    { 11, 4, "Corporis et quidem eos sit voluptate et molestiae.\nFugiat at necessitatibus cum ut repudiandae tempora quod temporibus id.\nAut fuga mollitia nulla.\nExpedita facilis voluptas ea architecto laborum minima excepturi.\nAt porro rerum quis dolorem.\nOdit sequi tempora.\nEa id est vero optio beatae dolorem.\nEst repudiandae libero cum enim.\nVelit non omnis officia voluptatem ut modi sunt vel.\nEsse velit nisi qui fuga.", new DateTime(2022, 10, 10, 13, 53, 48, 223, DateTimeKind.Local).AddTicks(9368), "Voluptates neque non qui." },
                    { 5, 4, "Facilis non qui velit quam optio voluptatem.\nAccusantium a sit tempora ullam qui quae.\nPariatur eius hic distinctio et.\nItaque voluptatem quia voluptatem maxime aperiam quisquam sequi.\nQui omnis optio enim inventore provident.\nQuis eveniet eligendi quia dignissimos.\nNatus similique sunt iste voluptas accusantium.\nOdio totam dolor facere doloribus officia et asperiores sequi.\nQuis vero accusamus laudantium animi tempore id excepturi maiores dolorem.\nNulla illo delectus distinctio non natus laudantium.", new DateTime(2022, 10, 10, 13, 53, 48, 223, DateTimeKind.Local).AddTicks(7220), "Facilis expedita quam quo." },
                    { 23, 3, "Tenetur quia exercitationem repudiandae totam molestiae velit iure.\nQui aut atque porro fugiat sunt ducimus quas dolorem.\nHic facilis quae modi quam veniam qui laborum.\nNon eos ut et quo ea.\nTemporibus et enim provident repellat perferendis et dignissimos saepe consequatur.\nAutem nobis similique eum voluptatibus necessitatibus consequuntur voluptas repellat.\nHic debitis harum perferendis vel sit eos et ipsum voluptatum.\nEx molestiae ullam sed incidunt harum optio itaque.\nId voluptas laborum.\nExpedita non dolorem cumque sequi vitae.", new DateTime(2022, 10, 10, 13, 53, 48, 224, DateTimeKind.Local).AddTicks(3491), "Atque illo qui ad." },
                    { 1, 3, "Itaque sed dolore suscipit blanditiis dignissimos expedita omnis quaerat.\nSit suscipit beatae amet reiciendis numquam perspiciatis ad incidunt et.\nNeque suscipit minima et iure excepturi occaecati dolore est.\nMolestias enim veritatis distinctio explicabo earum alias eum quidem quasi.\nQuas provident in et.\nAlias quis inventore.\nNobis nihil dolorum voluptatibus est sed ut sed quasi recusandae.\nProvident et earum molestias.\nSit cupiditate aut.\nUt necessitatibus mollitia asperiores fuga.", new DateTime(2022, 10, 10, 13, 53, 48, 221, DateTimeKind.Local).AddTicks(9178), "Et sapiente recusandae nobis." },
                    { 30, 1, "Rerum optio consequatur laudantium nobis eos modi.\nExercitationem velit quisquam.\nQui nostrum adipisci ipsa officia porro pariatur error repellendus dolorum.\nVeritatis repudiandae ratione quo officiis.\nInventore vitae quod molestiae officia ea eveniet omnis.\nDolor quia dicta quasi rerum.\nLibero fugit harum omnis maxime.\nCum quae ab a facere voluptatem ex maxime omnis ut.\nUt minima labore fugit reiciendis delectus.\nNon exercitationem minima exercitationem.", new DateTime(2022, 10, 10, 13, 53, 48, 224, DateTimeKind.Local).AddTicks(5958), "Ut omnis eveniet occaecati." },
                    { 21, 1, "Iure quae occaecati eveniet est maxime.\nEt voluptatibus vel sit facilis.\nNon voluptates praesentium.\nVoluptates atque ea veritatis odio.\nCorrupti eos veniam deserunt debitis illo debitis fugit.\nRepellendus et velit voluptatem voluptatem delectus.\nEsse id illum quae.\nQuia et saepe nihil qui fuga saepe tempora aliquam amet.\nRerum commodi aperiam omnis dignissimos sequi.\nMollitia aut voluptatem accusamus vero praesentium.", new DateTime(2022, 10, 10, 13, 53, 48, 224, DateTimeKind.Local).AddTicks(2825), "Adipisci dolores id deserunt." },
                    { 26, 10, "Earum quisquam velit.\nUt quos laudantium ex.\nFugit magni aperiam quam nam non quis.\nPraesentium temporibus est quod eos culpa atque voluptate.\nEnim quasi aliquid delectus.\nBlanditiis et hic quam expedita nobis natus omnis dicta ad.\nVelit et itaque id eum aliquam quam cum ea nihil.\nQui voluptatem vitae eos quo fugiat dicta modi qui.\nOfficia sed tempore.\nRem dolore omnis id nesciunt et.", new DateTime(2022, 10, 10, 13, 53, 48, 224, DateTimeKind.Local).AddTicks(4535), "Quia neque animi blanditiis." },
                    { 29, 10, "Aut eum eos sequi.\nNisi debitis iste molestias.\nLaboriosam ea ut est facilis et nisi alias.\nEsse adipisci molestias quaerat vel quis.\nAperiam temporibus dolorum ipsa ea suscipit hic exercitationem temporibus laborum.\nCulpa odit accusamus officiis iste.\nQui sint animi voluptas vel est quia nulla rerum.\nMagni alias mollitia sunt possimus et.\nNemo dicta itaque totam iure.\nBlanditiis illo itaque.", new DateTime(2022, 10, 10, 13, 53, 48, 224, DateTimeKind.Local).AddTicks(5629), "Amet rerum quo perspiciatis." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_AuthorId",
                table: "BlogPosts",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
