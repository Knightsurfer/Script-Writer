using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Script_Writer
{


    partial class Main : Form
    {

        #region ScriptWriter





        

        




        void CmdCat_Value(object sender, EventArgs e)
        {
            CommandBox.Items.Clear();
            switch (CategoryBox.Text)
            {
                case "All":

                    CommandBox.Items.Add("callstd");
                    CommandBox.Items.Add("callasm");
                    CommandBox.Items.Add("special");
                    CommandBox.Items.Add("special2");
                    CommandBox.Items.Add("gotostd");
                    CommandBox.Items.Add("resetvars");
                    CommandBox.Items.Add("countpokemon");

                    CommandBox.Items.Add("givecoins");
                    CommandBox.Items.Add("removecoins");
                    CommandBox.Items.Add("setwildbattle");
                    CommandBox.Items.Add("dowildbattle");
                    CommandBox.Items.Add("wildbattle");
                    CommandBox.Items.Add("wildbattle2");
                    CommandBox.Items.Add("addpcitem");
                    CommandBox.Items.Add("setpkmnpp");
                    CommandBox.Items.Add("choosecontestpkmn");
                    CommandBox.Items.Add("startcontest");
                    CommandBox.Items.Add("showcontestresults");
                    CommandBox.Items.Add("contestlinktransfer");
                    CommandBox.Items.Add("random");

                    CommandBox.Items.Add("fadescreen");
                    CommandBox.Items.Add("fadescreen3");
                    CommandBox.Items.Add("fadescreendelay");
                    CommandBox.Items.Add("darken");
                    CommandBox.Items.Add("lighten");
                    CommandBox.Items.Add("setdooropened");
                    CommandBox.Items.Add("setdooropened2");
                    CommandBox.Items.Add("setdoorclosed");
                    CommandBox.Items.Add("setdoorclosed2");
                    CommandBox.Items.Add("doorchange");
                    CommandBox.Items.Add("setdooropened2");
                    CommandBox.Items.Add("adddecoration");
                    CommandBox.Items.Add("removedecoration");
                    CommandBox.Items.Add("testdecoration");
                    CommandBox.Items.Add("jumpram");
                    CommandBox.Items.Add("executeram");
                    CommandBox.Items.Add("killscript");
                    CommandBox.Items.Add("setvar");
                    CommandBox.Items.Add("addvar");
                    CommandBox.Items.Add("subvar");
                    CommandBox.Items.Add("copyvar");
                    CommandBox.Items.Add("copyvarifnotzero");
                    CommandBox.Items.Add("pokenavcall");
                    CommandBox.Items.Add("registernav");
                    CommandBox.Items.Add("setcatchlocation");
                    CommandBox.Items.Add("applymovementpos");
                    CommandBox.Items.Add("spritebehave");
                    CommandBox.Items.Add("waitmovement");
                    CommandBox.Items.Add("waitmovementpos");
                    CommandBox.Items.Add("setanimation");
                    CommandBox.Items.Add("doanimation");
                    CommandBox.Items.Add("hidesprite");
                    CommandBox.Items.Add("hidespritepos");
                    CommandBox.Items.Add("showsprite");
                    CommandBox.Items.Add("showspritepos");
                    CommandBox.Items.Add("movesprite");
                    CommandBox.Items.Add("movesprite2");
                    CommandBox.Items.Add("moveoffscreen");
                    CommandBox.Items.Add("spritevisible");
                    CommandBox.Items.Add("spriteinvisible");
                    CommandBox.Items.Add("spriteface");
                    CommandBox.Items.Add("spritelevelup");
                    CommandBox.Items.Add("restorespritelevel");
                    CommandBox.Items.Add("createsprite");
                    CommandBox.Items.Add("spriteface2");
                    CommandBox.Items.Add("trainerbattle");
                    CommandBox.Items.Add("repeatetrainerbattle");
                    CommandBox.Items.Add("endtrainerbattle");
                    CommandBox.Items.Add("endtrainerbattle2");
                    CommandBox.Items.Add("lock");
                    CommandBox.Items.Add("lockall");
                    CommandBox.Items.Add("release");
                    CommandBox.Items.Add("releaseall");
                    CommandBox.Items.Add("waitstate");
                    CommandBox.Items.Add("pause");
                    CommandBox.Items.Add("getplayerpos");
                    CommandBox.Items.Add("end");
                    CommandBox.Items.Add("return");
                    CommandBox.Items.Add("setbyte");
                    CommandBox.Items.Add("setbyte2");
                    CommandBox.Items.Add("setfarbyte");
                    CommandBox.Items.Add("copybyte");
                    CommandBox.Items.Add("writebytetooffset");
                    CommandBox.Items.Add("loadbytefrompointer");
                    CommandBox.Items.Add("loadpointer");
                    CommandBox.Items.Add("copyscriptbanks");
                    CommandBox.Items.Add("setobedience");

                    break;


                case "Generic":
                    CommandBox.Items.Add("nop");
                    CommandBox.Items.Add("nop1");
                    CommandBox.Items.Add("call");
                    CommandBox.Items.Add("goto");
                    CommandBox.Items.Add("msgbox");
                    CommandBox.Items.Add("sound");
                    CommandBox.Items.Add("fanfare");
                    CommandBox.Items.Add("playsong");
                    CommandBox.Items.Add("cry");
                    CommandBox.Items.Add("sethealingplace");

                    break;

                case "Add":
                    CommandBox.Items.Add("additem");
                    break;

                case "Give":
                    CommandBox.Items.Add("giveitem");
                    CommandBox.Items.Add("giveitem2");
                    CommandBox.Items.Add("giveitem3");
                    CommandBox.Items.Add("givepokemon");
                    CommandBox.Items.Add("giveegg");
                    CommandBox.Items.Add("givemoney");


                    break;

                case "Remove":
                    CommandBox.Items.Add("removeitem");
                    CommandBox.Items.Add("paymoney");
                    break;

                case "Flags":
                    CommandBox.Items.Add("setflag");
                    CommandBox.Items.Add("clearflag");
                    CommandBox.Items.Add("checkflag");
                    CommandBox.Items.Add("checkdailyflags");
                    CommandBox.Items.Add("setworldmapflag");
                    CommandBox.Items.Add("checktrainerflag");
                    CommandBox.Items.Add("cleartrainerflag");
                    CommandBox.Items.Add("settrainerflag");
                    break;



                case "Buffer":
                    CommandBox.Items.Add("bufferitems");
                    CommandBox.Items.Add("bufferitems2");
                    CommandBox.Items.Add("bufferpokemon");
                    CommandBox.Items.Add("bufferfirstpokemon");
                    CommandBox.Items.Add("bufferitem");
                    CommandBox.Items.Add("bufferdecoration");
                    CommandBox.Items.Add("bufferattack");
                    CommandBox.Items.Add("buffernumber");
                    CommandBox.Items.Add("bufferstd");
                    CommandBox.Items.Add("bufferpublic string");
                    CommandBox.Items.Add("buffercontestype");
                    CommandBox.Items.Add("bufferboxname");
                    CommandBox.Items.Add("buffertrainerclass");
                    CommandBox.Items.Add("buffertrainername");
                    break;



                case "Query":
                    CommandBox.Items.Add("if1");
                    CommandBox.Items.Add("if2");
                    CommandBox.Items.Add("compare");
                    CommandBox.Items.Add("checkgender");
                    CommandBox.Items.Add("checkmoney");
                    CommandBox.Items.Add("gotostdif");
                    CommandBox.Items.Add("callstdif");
                    CommandBox.Items.Add("checkcoins");
                    CommandBox.Items.Add("checkitemroom");
                    CommandBox.Items.Add("checkitem");
                    CommandBox.Items.Add("checkitemtype");
                    CommandBox.Items.Add("checkpcitem");
                    CommandBox.Items.Add("checkattack");
                    CommandBox.Items.Add("checkdecoration");
                    CommandBox.Items.Add("checkanimation");
                    CommandBox.Items.Add("checksound");
                    CommandBox.Items.Add("checkobedience");
                    CommandBox.Items.Add("comparebanks");
                    CommandBox.Items.Add("comparebanktobyte");
                    CommandBox.Items.Add("comparebanktofarbyte");
                    CommandBox.Items.Add("comparefarbytetobank");
                    CommandBox.Items.Add("comparefarbytetobyte");
                    CommandBox.Items.Add("comparefarbytes");
                    CommandBox.Items.Add("comparevars");
                    CommandBox.Items.Add("comparehiddenvar");
                    break;

                case "Dialogue":
                    CommandBox.Items.Add("showcoins");
                    CommandBox.Items.Add("hidecoins");
                    CommandBox.Items.Add("updatecoins");
                    CommandBox.Items.Add("showmoney");
                    CommandBox.Items.Add("hidemoney");
                    CommandBox.Items.Add("updatemoney");
                    CommandBox.Items.Add("textcolor");
                    CommandBox.Items.Add("showbox");
                    CommandBox.Items.Add("hidebox");
                    CommandBox.Items.Add("hidebox2");
                    CommandBox.Items.Add("clearbox");
                    CommandBox.Items.Add("showpokepic");
                    CommandBox.Items.Add("hidepokepic");
                    CommandBox.Items.Add("showcontestwinner");
                    CommandBox.Items.Add("pokemart");
                    CommandBox.Items.Add("pokemart2");
                    CommandBox.Items.Add("pokemart3");
                    CommandBox.Items.Add("pokecasino");
                    CommandBox.Items.Add("braille");
                    CommandBox.Items.Add("signmsg");
                    CommandBox.Items.Add("normalmsg");
                    CommandBox.Items.Add("msgbox");
                    CommandBox.Items.Add("preparemsg");
                    CommandBox.Items.Add("waitmsg");
                    CommandBox.Items.Add("closeonkeypress");
                    CommandBox.Items.Add("waitkeypress");
                    CommandBox.Items.Add("yesnobox");
                    CommandBox.Items.Add("multichoice");
                    CommandBox.Items.Add("multichoice2");
                    CommandBox.Items.Add("multichoice3");

                    break;


                case "Sound":
                    CommandBox.Items.Add("waitfanfare");
                    CommandBox.Items.Add("playsong2");
                    CommandBox.Items.Add("fadedefault");
                    CommandBox.Items.Add("fadesong");
                    CommandBox.Items.Add("fadeout");
                    CommandBox.Items.Add("fadein");
                    CommandBox.Items.Add("waitcry");
                    break;

                case "Movement":
                    CommandBox.Items.Add("applymovement");
                    CommandBox.Items.Add("faceplayer");
                    break;


                case "Virtual":
                    CommandBox.Items.Add("setvirtualaddress");
                    CommandBox.Items.Add("virtualgoto");
                    CommandBox.Items.Add("virtualcall");
                    CommandBox.Items.Add("virtualgotoif");
                    CommandBox.Items.Add("virtualcallif");
                    CommandBox.Items.Add("virtualmsgbox");
                    CommandBox.Items.Add("virtualloadpointer");
                    CommandBox.Items.Add("virtualbuffer");
                    break;


                case "Warp":
                    CommandBox.Items.Add("warp");
                    CommandBox.Items.Add("warpmuted");
                    CommandBox.Items.Add("warpwalk");
                    CommandBox.Items.Add("warphole");
                    CommandBox.Items.Add("warpteleport");
                    CommandBox.Items.Add("warpteleport2");
                    CommandBox.Items.Add("warp3");
                    CommandBox.Items.Add("setwarpplace");
                    CommandBox.Items.Add("warp4");
                    CommandBox.Items.Add("warp5");
                    CommandBox.Items.Add("warp6");
                    break;






                case "Map Actions":
                    CommandBox.Items.Add("setmaptile");
                    CommandBox.Items.Add("doweather");
                    CommandBox.Items.Add("setweather");
                    CommandBox.Items.Add("resetweather");
                    CommandBox.Items.Add("setmapfooter");
                    break;


                case "Other":
                    CommandBox.Items.Add("warp7");
                    CommandBox.Items.Add("warp8");
                    CommandBox.Items.Add("cmd24");
                    CommandBox.Items.Add("cmd2c");
                    CommandBox.Items.Add("cmd8a");
                    CommandBox.Items.Add("cmd96");
                    CommandBox.Items.Add("cmda6");
                    CommandBox.Items.Add("cmdb1");
                    CommandBox.Items.Add("cmdb2");
                    CommandBox.Items.Add("cmdc3");
                    CommandBox.Items.Add("cmdc8");
                    CommandBox.Items.Add("cmdc9");
                    CommandBox.Items.Add("cmdd5");
                    CommandBox.Items.Add("cmdd6");
                    CommandBox.Items.Add("cmdd8");
                    CommandBox.Items.Add("cmdd9");
                    CommandBox.Items.Add("braille2");
                    CommandBox.Items.Add("preparemsg2");
                    CommandBox.Items.Add("preparemsg3");
                    break;


            }
        }
        void CmdBox_value(object sender, EventArgs e)
        {
            desc_read = cini.Read(CommandBox.Text, "Description"); Description.Text = desc_read;
            type_read = cini.Read(CommandBox.Text, "Type"); Types.Text = type_read;
            bytes_read = cini.Read(CommandBox.Text, "Bytes Used"); BytesUsed.Text = bytes_read;
            use_read = cini.Read(CommandBox.Text, "Usage"); Usage.Text = use_read;

            arg_read = cini.Read(CommandBox.Text, "Arguments");
        }

   
        #endregion






















    }
}
