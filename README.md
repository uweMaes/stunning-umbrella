# stunning-umbrella odx-Desing für Blazor 

## Idee

Erstellen von einzelnen Blazor Komponenten im odx-Design 

## Komponenten 

### Modal

Modal.razor

```razor
    <div class="odx-modal-backdrop" @onclick="CloseModal">
        <div class="odx-modal odx-modal--medium" @onclick:stopPropagation="true">
            <div class="odx-modal__container">
                <div class="odx-modal__header">
                    <h3 class="odx-area-header">Titel</h3>
                    <button class="odx-modal__close" @onclick="CloseModal">&times;</button>
                </div>
                <div class="odx-modal__content">
                    @ChildContent
                </div>
                <div class="odx-modal__footer">
                    <button class="odx-button" @onclick="CloseModal">Schließen</button>
                </div>
            </div>
        </div>
    </div>
```

mit eigener Modal.razor.css

```css
.modal-overlay {
    display: none;
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background: rgba(0, 0, 0, 0.5);
    z-index: 1000;
    align-items: center;
    justify-content: center;
    opacity: 0;
    transition: opacity 0.3s ease-in-out;
}

.modal-overlay.show {
    display: flex;
    opacity: 1;
}

.modal-content {
    background: white;
    padding: 20px;
    border-radius: 8px;
    width: 400px;
    box-shadow: 0px 5px 15px rgba(0, 0, 0, 0.3);
    animation: fadeIn 0.3s ease-in-out;
}

.modal-close {
    position: absolute;
    top: 10px;
    right: 10px;
    border: none;
    background: none;
    font-size: 24px;
    cursor: pointer;
}

@keyframes fadeIn {
    from {
        transform: scale(0.9);
        opacity: 0;
    }
    to {
        transform: scale(1);
        opacity: 1;
    }
}
```