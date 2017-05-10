	function surligne(champ, erreur)
	{
		if(erreur)
		{
			champ.style.borderColor = "#FF6060";
			champ.value
		}
		else
		{
				champ.style.borderColor = "#13EB41";
		}
	}

	function verifPseudo(champ)
	{
		if(champ.value.length < 3 || champ.value.length > 20)
		{
			surligne(champ,true);
			return false;
		}
		else
		{
			surligne(champ,false);
			return false;
		}
	}

	function verifMail(champ)
	{
		var regex = /^[a-zA-Z0-9._-]+@[a-z0-9._-]{2,}\.[a-z]{2,4}$/;
		if(!regex.test(champ.value))
  		{
 			surligne(champ, true);
      		return false;
   		}
   		else
   		{
      		surligne(champ, false);
      		return true;
   		}
	}

	function verifPrenom(champ)
	{
		if(champ.value.length != 0 && champ.value.length < 25)
		{
			surligne(champ, false);
		}
		else
		{
			surligne(champ, true);
		}
	}
	
		function verifNom(champ)
	{
		if(champ.value.length != 0 && champ.value.length < 25)
		{
			surligne(champ, false);
		}
		else
		{
			surligne(champ, true);
		}
	}


	function verifMdp1(champ)
	{

		if(champ.value.length >= 6 && champ.value.length <= 20)
		{
			surligne(champ, false);
		}
		else
		{
			surligne(champ, true);
		}
	}

	function testCorresp(champ, champ2)
	{
		if(champ.value == champ2.value)
		{
			surligne(champ, false)
		}
		else
		{
			surligne(champ, true);
		}
	}

	function verifForm(f)
	{
		var prenom = verifPrenom(f.prenom);
		var nomUser = verifNom(f.nom);
		var pseudo = verifPseudo(f.pseudo);
		var mail = verifMail(f.mail);
		var mdp1 = verifMdp1(f.mdp1);
		var mdp2 = testCorresp(f.mdp2);

		if(prenom && nom && pseudo && mail && mdp1 && mdp2)
		{
			return true;
		}
		else
		{
			alert("Veuillez remplir tous les champs correctement s'il vous plait.");
			return false;
		}
	}
