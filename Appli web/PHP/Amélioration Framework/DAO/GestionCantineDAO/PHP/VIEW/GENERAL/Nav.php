<div>
    <?php
        if (isset($_SESSION['utilisateur'])) {
    ?>
            <nav class="colonne center">
                <div class="miniEspace"></div>
                <div>
                    <div></div>
                    <a href="index.php?page=accueil">
                        <div>
                        <i class="far fa-light fa-alicorn fa-3x"></i>
                        </div>
                    </a>
                    <div></div>
                </div>              
                <div class="miniEspace"></div>
                <div>
                    <div></div>
                    <a href="index.php?page=formPaiement&mode=Ajout">
                        <div>
                        <i class="fa-light fa-alien fa-3x"></i>
                        </div>
                    </a>
                    <div></div>
                </div>
                <div class="miniEspace"></div>
            </nav>
    <?php
        }
    ?>