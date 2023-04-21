{$CLEO .cs}
0000: NOP 
script_name 'PARKOUR' 

:PARKOUR_13
wait 10 
if 
  Player.Defined($PLAYER_CHAR)
jf @PARKOUR_13 
04ED: load_animation "ANIMATIONS" 

:PARKOUR_45
wait 10 
if and
  is_key_pressed 49 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_109 
0605: actor $PLAYER_ACTOR perform_animation "ANIM2" IFP "ANIMATIONS" framedelta 4.0 loop 1 lockX 1 lockY 1 lockF 0 time 2100 
wait 1500 

:PARKOUR_109
wait 10 
if and
  is_key_pressed 56 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_176 
0605: actor $PLAYER_ACTOR perform_animation "ANIM1" IFP "ANIMATIONS" framedelta 4.0 loop 1 lockX 1 lockY 1 lockF 0 time 2100 
wait 500 

:PARKOUR_176
wait 10 
if and
  is_key_pressed 54 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_242 
0605: actor $PLAYER_ACTOR perform_animation "ANIM3" IFP "ANIMATIONS" framedelta 4.0 loop 1 lockX 1 lockY 1 lockF 0 time 2550 
wait 200 

:PARKOUR_242
wait 10 
if and
  is_key_pressed 73 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_315 
0605: actor $PLAYER_ACTOR perform_animation "ANIM4" IFP "ANIMATIONS" framedelta 4.0 loop 1 lockX 1 lockY 1 lockF 0 time 3200 
wait 1500 

:PARKOUR_315
wait 10 
if and
  is_key_pressed 48 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_383 
0605: actor $PLAYER_ACTOR perform_animation "ANIM5" IFP "ANIMATIONS" framedelta 4.0 loop 1 lockX 1 lockY 1 lockF 0 time 1900 
wait 1500 

:PARKOUR_383
wait 10 
if and
  is_key_pressed 84 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_453 
0605: actor $PLAYER_ACTOR perform_animation "ANIM5ANIM2" IFP "ANIMATIONS" framedelta 4.0 loop 1 lockX 1 lockY 1 lockF 0 time 3050 
wait 1500 

:PARKOUR_453
wait 10 
if and
  is_key_pressed 53 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_520 
0605: actor $PLAYER_ACTOR perform_animation "ANIM7" IFP "ANIMATIONS" framedelta 4.0 loop 1 lockX 1 lockY 1 lockF 0 time 2680 
wait 1500 

:PARKOUR_520
wait 10 
if and
  is_key_pressed 50 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_590 
0605: actor $PLAYER_ACTOR perform_animation "ANIM9" IFP "ANIMATIONS" framedelta 4.0 loop 1 lockX 1 lockY 1 lockF 0 time 3060 
wait 1500 

:PARKOUR_590
wait 10 
if and
  is_key_pressed 55 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_659 
0605: actor $PLAYER_ACTOR perform_animation "ANIM20" IFP "ANIMATIONS" framedelta 4.0 loop 1 lockX 1 lockY 1 lockF 0 time 3050 
wait 1500 

:PARKOUR_659
wait 10 
if and
  is_key_pressed 89 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_729 
0605: actor $PLAYER_ACTOR perform_animation "ANIM12" IFP "ANIMATIONS" framedelta 4.0 loop 1 lockX 1 lockY 1 lockF 0 time 2950 
wait 1500 

:PARKOUR_729
wait 10 
if and
  is_key_pressed 71 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_798 
0605: actor $PLAYER_ACTOR perform_animation "ANIM8" IFP "ANIMATIONS" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 
wait 1500 

:PARKOUR_798
wait 10 
if and
  is_key_pressed 52 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_866 
0605: actor $PLAYER_ACTOR perform_animation "ANIM10" IFP "ANIMATIONS" framedelta 4.0 loop 1 lockX 1 lockY 1 lockF 0 time 4000 
wait 1500 

:PARKOUR_866
wait 10 
if and
  is_key_pressed 72 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_937 
0605: actor $PLAYER_ACTOR perform_animation "ANIM11" IFP "ANIMATIONS" framedelta 4.0 loop 1 lockX 1 lockY 1 lockF 0 time 9200 
wait 1500 

:PARKOUR_937
wait 10 
if and
  is_key_pressed 79 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_1004 
0605: actor $PLAYER_ACTOR perform_animation "ANIM13" IFP "ANIMATIONS" framedelta 4.0 loop 1 lockX 1 lockY 1 lockF 0 time 3000 
wait 1500 

:PARKOUR_1004
wait 10 
if and
  is_key_pressed 80 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_1073 
0605: actor $PLAYER_ACTOR perform_animation "ANIM14" IFP "ANIMATIONS" framedelta 4.0 loop 1 lockX 1 lockY 1 lockF 0 time 3160 
wait 1500 

:PARKOUR_1073
wait 10 
if and
  is_key_pressed 57 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_1139 
0605: actor $PLAYER_ACTOR perform_animation "ANIM15" IFP "ANIMATIONS" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 
wait 3990 

:PARKOUR_1139
wait 10 
if and
  is_key_pressed 51 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_1209 
0605: actor $PLAYER_ACTOR perform_animation "ANIM16" IFP "ANIMATIONS" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time 3000 
wait 1000 

:PARKOUR_1209
wait 10 
if and
  is_key_pressed 74 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_1275 
0605: actor $PLAYER_ACTOR perform_animation "ANIM17" IFP "ANIMATIONS" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 
wait 1000 

:PARKOUR_1275
wait 10 
if and
  is_key_pressed 75 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_1341 
0605: actor $PLAYER_ACTOR perform_animation "ANIM18" IFP "ANIMATIONS" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 
wait 1000 

:PARKOUR_1341
wait 10 
if and
  is_key_pressed 76 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_1407 
0605: actor $PLAYER_ACTOR perform_animation "ANIM19" IFP "ANIMATIONS" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 
wait 1000 

:PARKOUR_1407
wait 10 
if and
  is_key_pressed 85 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_1476 
0605: actor $PLAYER_ACTOR perform_animation "ANIM21" IFP "ANIMATIONS" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 
wait 1000 

:PARKOUR_1476
wait 10 
if and
  is_key_pressed 66 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_1545 
0605: actor $PLAYER_ACTOR perform_animation "ANIM22" IFP "ANIMATIONS" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 
wait 1000 

:PARKOUR_1545
wait 10 
if and
  is_key_pressed 78 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_1615 
0605: actor $PLAYER_ACTOR perform_animation "ANIM23" IFP "ANIMATIONS" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 
wait 1000 

:PARKOUR_1615
wait 10 
if and
  is_key_pressed 77 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_1687 
0605: actor $PLAYER_ACTOR perform_animation "ANIM24" IFP "ANIMATIONS" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time 2560 
wait 1000 

:PARKOUR_1687
wait 10 
if and
  is_key_pressed 188 
044B:   actor $PLAYER_ACTOR on_foot 
jf @PARKOUR_45 
0605: actor $PLAYER_ACTOR perform_animation "ANIM25" IFP "ANIMATIONS" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 
wait 1000 
jump @PARKOUR_13 
terminate_this_custom_script 
