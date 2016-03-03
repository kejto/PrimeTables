﻿using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeTables.Algorithms;

namespace PrimeTables.Tests.Integration
{
    [TestClass]
    public class PrimeTablesTests
    {
        [TestMethod]
        public void When_User_Input_IsValid_Return_Prime_Table_Calculadted_By_Naive_Small_Number()
        {
            var primeTable = new PrimeTable(3, new Context(new Naive()));
            var results = primeTable.GeneratePrimes();
            Assert.AreEqual("|2|4|6|10|", results[1]);
        }

        [TestMethod]
        public void When_User_Input_IsValid_Return_Prime_Table_Calculadted_By_SieveOfAtkins_Small_Number()
        {
            var primeTable = new PrimeTable(3, new Context(new SieveOfSundaram()));
            var results = primeTable.GeneratePrimes();
            Assert.AreEqual("|2|4|6|10|", results[1]);
        }

        [TestMethod]
        public void When_User_Input_IsValid_Return_Prime_Table_Calculadted_By_SieveOfAtkins_Big_Number()
        {
            var primeTable = new PrimeTable(1000, new Context(new SieveOfSundaram()));
            var results = primeTable.GeneratePrimes();
            string thousandPrimeNumber = "|7919|15838|23757|39595|55433|87109|102947|134623|150461|182137|229651|245489|293003|324679|340517|372193|419707|467221|483059|530573|562249|578087|625601|657277|704791|768143|799819|815657|847333|863171|894847|1005713|1037389|1084903|1100741|1179931|1195769|1243283|1290797|1322473|1369987|1417501|1433339|1512529|1528367|1560043|1575881|1670909|1765937|1797613|1813451|1845127|1892641|1908479|1987669|2035183|2082697|2130211|2146049|2193563|2225239|2241077|2320267|2431133|2462809|2478647|2510323|2621189|2668703|2747893|2763731|2795407|2842921|2906273|2953787|3001301|3032977|3080491|3143843|3175519|3238871|3318061|3333899|3413089|3428927|3476441|3508117|3555631|3618983|3650659|3666497|3698173|3793201|3856553|3888229|3951581|3983257|4030771|4125799|4141637|4284179|4331693|4410883|4458397|4505911|4521749|4569263|4648453|4695967|4743481|4759319|4806833|4854347|4886023|4901861|4996889|5076079|5091917|5123593|5171107|5218621|5234459|5329487|5361163|5408677|5472029|5551219|5614571|5693761|5757113|5804627|5852141|5883817|5947169|5994683|6026359|6089711|6121387|6232253|6311443|6406471|6422309|6501499|6517337|6549013|6564851|6644041|6754907|6786583|6802421|6834097|6944963|6976639|6992477|7024153|7182533|7214209|7277561|7356751|7420103|7451779|7499293|7546807|7657673|7689349|7736863|7784377|7847729|7895243|7990271|8021947|8069461|8085299|8164489|8180327|8227841|8307031|8322869|8402059|8417897|8465411|8607953|8639629|8655467|8687143|8734657|8782171|8845523|8893037|8940551|9114769|9130607|9209797|9273149|9352339|9399853|9447367|9510719|9605747|9637423|9684937|9732451|9748289|9795803|9890831|9970021|10112563|10128401|10160077|10207591|10223429|10270943|10302619|10318457|10350133|10445161|10460999|10508513|10777759|10825273|10872787|10936139|11078681|11157871|11268737|11300413|11316251|11347927|11395441|11458793|11490469|11506307|11553821|11648849|11728039|11743877|11775553|11791391|11823067|11870581|11965609|12060637|12123989|12219017|12266531|12298207|12345721|12409073|12440749|12504101|12535777|12646643|12678319|12725833|12741671|12773347|12820861|12836699|12884213|12963403|13121783|13169297|13200973|13216811|13406867|13438543|13454381|13533571|13628599|13644437|13723627|13786979|13834493|13882007|13929521|14072063|14119577|14151253|14167091|14262119|14341309|14436337|14499689|14626393|14737259|14784773|14816449|14832287|14863963|14879801|14958991|15054019|15101533|15149047|15291589|15307427|15434131|15449969|15624187|15671701|15735053|15782567|15814243|15830081|15861757|15925109|15972623|16051813|16067651|16146841|16257707|16336897|16384411|16479439|16495277|16526953|16542791|16621981|16717009|16732847|16859551|16875389|16922903|16954579|16970417|17049607|17112959|17255501|17445557|17477233|17524747|17588099|17714803|17730641|17762317|17825669|17952373|17968211|17999887|18063239|18110753|18158267|18189943|18284971|18300809|18475027|18522541|18538379|18585893|18617569|18665083|18775949|18823463|18855139|18870977|18918491|18950167|18997681|19092709|19140223|19187737|19298603|19330279|19377793|19472821|19536173|19583687|19615363|19821257|19963799|20042989|20106341|20138017|20185531|20201369|20248883|20423101|20518129|20533967|20660671|20724023|20755699|20850727|20961593|21040783|21056621|21088297|21151649|21199163|21246677|21278353|21294191|21325867|21373381|21436733|21468409|21484247|21531761|21610951|21626789|21705979|21769331|21801007|21911873|21991063|22086091|22101929|22149443|22181119|22196957|22323661|22434527|22466203|22513717|22577069|22624583|22656259|22798801|22862153|22941343|22988857|23036371|23099723|23178913|23273941|23384807|23416483|23463997|23511511|23527349|23749081|23764919|23844109|23907461|23939137|24050003|24081679|24145031|24240059|24287573|24382601|24414277|24461791|24620171|24699361|24715199|24841903|25047797|25079473|25095311|25190339|25237853|25269529|25364557|25412071|25475423|25507099|25570451|25744669|25760507|25792183|25808021|25903049|26124781|26140619|26188133|26235647|26283161|26314837|26362351|26378189|26473217|26504893|26599921|26615759|26694949|26710787|26837491|26853329|26980033|27027547|27185927|27312631|27375983|27407659|27423497|27455173|27471011|27645229|27708581|27803609|27851123|27930313|27946151|27977827|28025341|28041179|28088693|28167883|28183721|28278749|28357939|28373777|28452967|28563833|28611347|28643023|28690537|28753889|28801403|28848917|28975621|29070649|29086487|29118163|29229029|29276543|29308219|29371571|29450761|29514113|29561627|29609141|29783359|29830873|29846711|29925901|30036767|30068443|30115957|30258499|30274337|30353527|30464393|30496069|30511907|30591097|30701963|30733639|30796991|30939533|30971209|31018723|31034561|31066237|31113751|31129589|31224617|31256293|31414673|31588891|31683919|31699757|31731433|31778947|31826461|31842299|31889813|32064031|32079869|32127383|32254087|32301601|32396629|32412467|32459981|32555009|32681713|32697551|32729227|32776741|32887607|32919283|32935121|33077663|33267719|33346909|33394423|33410261|33489451|33505289|33584479|33600317|33679507|33727021|33742859|33822049|33837887|33917077|33964591|34027943|34265513|34344703|34360541|34439731|34503083|34550597|34629787|34772329|34819843|34914871|35009899|35025737|35168279|35215793|35247469|35294983|35342497|35485039|35500877|35580067|35690933|35738447|35770123|35785961|35817637|36007693|36023531|36118559|36166073|36292777|36356129|36403643|36451157|36593699|36720403|36736241|36767917|36815431|36831269|36878783|36926297|37005487|37053001|37148029|37243057|37385599|37401437|37448951|37480627|37623169|37686521|37876577|37908253|37924091|37955767|38003281|38019119|38114147|38145823|38256689|38494259|38573449|38620963|38715991|38826857|38874371|38953561|39048589|39064427|39096103|39143617|39206969|39254483|39333673|39349511|39381187|39492053|39539567|39587081|39618757|39666271|39682109|39761299|39777137|39903841|39998869|40062221|40204763|40236439|40283953|40378981|40394819|40442333|40489847|40537361|40759093|40806607|40917473|40949149|41012501|41091691|41155043|41250071|41392613|41424289|41440127|41471803|41661859|41756887|41804401|41820239|41946943|41994457|42041971|42152837|42232027|42342893|42374569|42612139|42659653|42707167|42754681|42818033|42865547|42897223|42913061|43008089|43055603|43087279|43103117|43150631|43324849|43372363|43388201|43419877|43562419|43578257|43609933|43704961|43720799|43768313|43799989|44005883|44053397|44100911|44132587|44195939|44275129|44528537|44655241|44671079|44718593|44750269|44766107|44797783|44813621|44892811|45003677|45051191|45082867|45146219|45225409|45272923|45431303|45462979|45478817|45526331|45763901|45795577|45858929|45938119|45985633|46033147|46096499|46144013|46239041|46270717|46318231|46334069|46381583|46413259|46460773|46476611|46555801|46571639|46698343|46745857|46904237|46935913|47030941|47141807|47363539|47411053|47569433|47601109|47743651|47807003|47854517|47886193|47933707|48044573|48092087|48139601|48218791|48234629|48313819|48408847|48472199|48551389|48567227|48646417|48709769|48804797|48883987|49074043|49089881|49121557|49184909|49232423|49264099|49327451|49469993|49549183|49596697|49644211|49660049|49707563|49786753|49881781|49897619|49976809|50024323|50071837|50119351|50182703|50230217|50309407|50356921|50372759|50420273|50467787|50515301|50594491|50657843|50847899|50895413|51069631|51085469|51228011|51259687|51323039|51402229|51639799|51703151|51845693|51877369|51893207|51972397|52019911|52035749|52083263|52114939|52257481|52320833|52415861|52558403|52685107|52732621|52748459|52843487|52891001|52970191|52986029|53065219|53081057|53128571|53207761|53318627|53350303|53540359|53556197|53682901|53698739|53777929|53793767|53872957|54031337|54063013|54078851|54110527|54173879|54300583|54348097|54395611|54411449|54506477|54633181|54696533|54728209|54775723|55013293|55029131|55108321|55124159|55171673|55203349|55250863|55298377|55361729|55409243|55440919|55535947|55583461|55646813|55741841|55773517|55884383|55979411|56058601|56248657|56296171|56391199|56438713|56454551|56628769|56692121|56834663|56913853|56961367|57072233|57103909|57119747|57167261|57246451|57309803|57357317|57388993|57436507|57674077|57784943|57864133|57879971|57974999|58054189|58070027|58196731|58212569|58355111|58545167|58687709|58735223|58861927|59004469|59051983|59067821|59210363|59242039|59289553|59305391|59384581|59447933|59527123|59574637|59622151|59685503|59717179|59764693|59780531|59859721|59875559|59970587|60002263|60049777|60097291|60113129|60208157|60239833|60350699|60493241|60524917|60572431|60730811|60762487|60825839|60873353|60905029|60968381|61000057|61110923|61158437|61190113|61300979|61396007|61427683|61443521|61681091|61712767|61902823|61950337|61997851|62092879|62187907|62298773|62346287|62377963|62393801|62425477|62568019|62615533|62710561|";
            Assert.AreEqual(thousandPrimeNumber, results[1000]);
        }

        [TestMethod]
        public void Compare_Two_Different_Methods()
        {
            BigInteger primeNumbers = 500;

            var primeTableNaive = new PrimeTable(primeNumbers, new Context(new Naive()));
            var resultsNaive = primeTableNaive.GeneratePrimes();

            var primeTableSieveOfSundaram = new PrimeTable(primeNumbers, new Context(new SieveOfSundaram()));
            var results = primeTableSieveOfSundaram.GeneratePrimes();

            Assert.AreEqual(resultsNaive[500], results[500]);
        }
    }
}